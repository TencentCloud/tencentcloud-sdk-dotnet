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
       private const string sdkVersion = "SDK_NET_3.0.1019";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// AddCLSTopicDomains 用于新增域名到某日志主题下
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public Task<AddCLSTopicDomainsResponse> AddCLSTopicDomains(AddCLSTopicDomainsRequest req)
        {
            return InternalRequestAsync<AddCLSTopicDomainsResponse>(req, "AddCLSTopicDomains");
        }

        /// <summary>
        /// AddCLSTopicDomains 用于新增域名到某日志主题下
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public AddCLSTopicDomainsResponse AddCLSTopicDomainsSync(AddCLSTopicDomainsRequest req)
        {
            return InternalRequestAsync<AddCLSTopicDomainsResponse>(req, "AddCLSTopicDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AddCdnDomain 用于新增内容分发网络加速域名。1分钟内最多可新增100个域名。
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public Task<AddCdnDomainResponse> AddCdnDomain(AddCdnDomainRequest req)
        {
            return InternalRequestAsync<AddCdnDomainResponse>(req, "AddCdnDomain");
        }

        /// <summary>
        /// AddCdnDomain 用于新增内容分发网络加速域名。1分钟内最多可新增100个域名。
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public AddCdnDomainResponse AddCdnDomainSync(AddCdnDomainRequest req)
        {
            return InternalRequestAsync<AddCdnDomainResponse>(req, "AddCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateClsLogTopic 用于创建日志主题。注意：一个日志集下至多可创建10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public Task<CreateClsLogTopicResponse> CreateClsLogTopic(CreateClsLogTopicRequest req)
        {
            return InternalRequestAsync<CreateClsLogTopicResponse>(req, "CreateClsLogTopic");
        }

        /// <summary>
        /// CreateClsLogTopic 用于创建日志主题。注意：一个日志集下至多可创建10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public CreateClsLogTopicResponse CreateClsLogTopicSync(CreateClsLogTopicRequest req)
        {
            return InternalRequestAsync<CreateClsLogTopicResponse>(req, "CreateClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// CreateDiagnoseUrl 用于添加域名诊断任务URL。
        /// </summary>
        /// <param name="req"><see cref="CreateDiagnoseUrlRequest"/></param>
        /// <returns><see cref="CreateDiagnoseUrlResponse"/></returns>
        public Task<CreateDiagnoseUrlResponse> CreateDiagnoseUrl(CreateDiagnoseUrlRequest req)
        {
            return InternalRequestAsync<CreateDiagnoseUrlResponse>(req, "CreateDiagnoseUrl");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// CreateDiagnoseUrl 用于添加域名诊断任务URL。
        /// </summary>
        /// <param name="req"><see cref="CreateDiagnoseUrlRequest"/></param>
        /// <returns><see cref="CreateDiagnoseUrlResponse"/></returns>
        public CreateDiagnoseUrlResponse CreateDiagnoseUrlSync(CreateDiagnoseUrlRequest req)
        {
            return InternalRequestAsync<CreateDiagnoseUrlResponse>(req, "CreateDiagnoseUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 动态打包任务提交接口
        /// </summary>
        /// <param name="req"><see cref="CreateEdgePackTaskRequest"/></param>
        /// <returns><see cref="CreateEdgePackTaskResponse"/></returns>
        public Task<CreateEdgePackTaskResponse> CreateEdgePackTask(CreateEdgePackTaskRequest req)
        {
            return InternalRequestAsync<CreateEdgePackTaskResponse>(req, "CreateEdgePackTask");
        }

        /// <summary>
        /// 动态打包任务提交接口
        /// </summary>
        /// <param name="req"><see cref="CreateEdgePackTaskRequest"/></param>
        /// <returns><see cref="CreateEdgePackTaskResponse"/></returns>
        public CreateEdgePackTaskResponse CreateEdgePackTaskSync(CreateEdgePackTaskRequest req)
        {
            return InternalRequestAsync<CreateEdgePackTaskResponse>(req, "CreateEdgePackTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateScdnDomain 用于创建 SCDN 加速域名
        /// </summary>
        /// <param name="req"><see cref="CreateScdnDomainRequest"/></param>
        /// <returns><see cref="CreateScdnDomainResponse"/></returns>
        public Task<CreateScdnDomainResponse> CreateScdnDomain(CreateScdnDomainRequest req)
        {
            return InternalRequestAsync<CreateScdnDomainResponse>(req, "CreateScdnDomain");
        }

        /// <summary>
        /// CreateScdnDomain 用于创建 SCDN 加速域名
        /// </summary>
        /// <param name="req"><see cref="CreateScdnDomainRequest"/></param>
        /// <returns><see cref="CreateScdnDomainResponse"/></returns>
        public CreateScdnDomainResponse CreateScdnDomainSync(CreateScdnDomainRequest req)
        {
            return InternalRequestAsync<CreateScdnDomainResponse>(req, "CreateScdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateScdnFailedLogTask 用于重试创建失败的事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public Task<CreateScdnFailedLogTaskResponse> CreateScdnFailedLogTask(CreateScdnFailedLogTaskRequest req)
        {
            return InternalRequestAsync<CreateScdnFailedLogTaskResponse>(req, "CreateScdnFailedLogTask");
        }

        /// <summary>
        /// CreateScdnFailedLogTask 用于重试创建失败的事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public CreateScdnFailedLogTaskResponse CreateScdnFailedLogTaskSync(CreateScdnFailedLogTaskRequest req)
        {
            return InternalRequestAsync<CreateScdnFailedLogTaskResponse>(req, "CreateScdnFailedLogTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateScdnLogTask 用于创建事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnLogTaskResponse"/></returns>
        public Task<CreateScdnLogTaskResponse> CreateScdnLogTask(CreateScdnLogTaskRequest req)
        {
            return InternalRequestAsync<CreateScdnLogTaskResponse>(req, "CreateScdnLogTask");
        }

        /// <summary>
        /// CreateScdnLogTask 用于创建事件日志任务
        /// </summary>
        /// <param name="req"><see cref="CreateScdnLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnLogTaskResponse"/></returns>
        public CreateScdnLogTaskResponse CreateScdnLogTaskSync(CreateScdnLogTaskRequest req)
        {
            return InternalRequestAsync<CreateScdnLogTaskResponse>(req, "CreateScdnLogTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateVerifyRecord 用于生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// 生成的解析记录可通过 [VerifyDomainRecord](https://cloud.tencent.com/document/product/228/48117) 完成归属权校验。
        /// 注意：生成的解析记录有效期为24小时，超过24小时后，需重新生成。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateVerifyRecordResponse"/></returns>
        public Task<CreateVerifyRecordResponse> CreateVerifyRecord(CreateVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateVerifyRecordResponse>(req, "CreateVerifyRecord");
        }

        /// <summary>
        /// CreateVerifyRecord 用于生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// 生成的解析记录可通过 [VerifyDomainRecord](https://cloud.tencent.com/document/product/228/48117) 完成归属权校验。
        /// 注意：生成的解析记录有效期为24小时，超过24小时后，需重新生成。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateVerifyRecordResponse"/></returns>
        public CreateVerifyRecordResponse CreateVerifyRecordSync(CreateVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateVerifyRecordResponse>(req, "CreateVerifyRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteCdnDomain 用于删除指定加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public Task<DeleteCdnDomainResponse> DeleteCdnDomain(DeleteCdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteCdnDomainResponse>(req, "DeleteCdnDomain");
        }

        /// <summary>
        /// DeleteCdnDomain 用于删除指定加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public DeleteCdnDomainResponse DeleteCdnDomainSync(DeleteCdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteCdnDomainResponse>(req, "DeleteCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteClsLogTopic 用于删除日志主题。注意：删除后，所有该日志主题下绑定域名的日志将不再继续投递至该主题，已经投递的日志将会被全部清空。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public Task<DeleteClsLogTopicResponse> DeleteClsLogTopic(DeleteClsLogTopicRequest req)
        {
            return InternalRequestAsync<DeleteClsLogTopicResponse>(req, "DeleteClsLogTopic");
        }

        /// <summary>
        /// DeleteClsLogTopic 用于删除日志主题。注意：删除后，所有该日志主题下绑定域名的日志将不再继续投递至该主题，已经投递的日志将会被全部清空。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public DeleteClsLogTopicResponse DeleteClsLogTopicSync(DeleteClsLogTopicRequest req)
        {
            return InternalRequestAsync<DeleteClsLogTopicResponse>(req, "DeleteClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除SCDN域名
        /// </summary>
        /// <param name="req"><see cref="DeleteScdnDomainRequest"/></param>
        /// <returns><see cref="DeleteScdnDomainResponse"/></returns>
        public Task<DeleteScdnDomainResponse> DeleteScdnDomain(DeleteScdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteScdnDomainResponse>(req, "DeleteScdnDomain");
        }

        /// <summary>
        /// 删除SCDN域名
        /// </summary>
        /// <param name="req"><see cref="DeleteScdnDomainRequest"/></param>
        /// <returns><see cref="DeleteScdnDomainResponse"/></returns>
        public DeleteScdnDomainResponse DeleteScdnDomainSync(DeleteScdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteScdnDomainResponse>(req, "DeleteScdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeBillingData 用于查询实际计费数据明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData");
        }

        /// <summary>
        /// DescribeBillingData 用于查询实际计费数据明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CC统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCcDataRequest"/></param>
        /// <returns><see cref="DescribeCcDataResponse"/></returns>
        public Task<DescribeCcDataResponse> DescribeCcData(DescribeCcDataRequest req)
        {
            return InternalRequestAsync<DescribeCcDataResponse>(req, "DescribeCcData");
        }

        /// <summary>
        /// CC统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCcDataRequest"/></param>
        /// <returns><see cref="DescribeCcDataResponse"/></returns>
        public DescribeCcDataResponse DescribeCcDataSync(DescribeCcDataRequest req)
        {
            return InternalRequestAsync<DescribeCcDataResponse>(req, "DescribeCcData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeCdnData 用于查询 CDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 命中请求数（单位为 次）
        /// + 请求命中率（单位为 %）
        /// + 命中流量（单位为 byte）
        /// + 流量命中率（单位为 %）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public Task<DescribeCdnDataResponse> DescribeCdnData(DescribeCdnDataRequest req)
        {
            return InternalRequestAsync<DescribeCdnDataResponse>(req, "DescribeCdnData");
        }

        /// <summary>
        /// DescribeCdnData 用于查询 CDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 命中请求数（单位为 次）
        /// + 请求命中率（单位为 %）
        /// + 命中流量（单位为 byte）
        /// + 流量命中率（单位为 %）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public DescribeCdnDataResponse DescribeCdnDataSync(DescribeCdnDataRequest req)
        {
            return InternalRequestAsync<DescribeCdnDataResponse>(req, "DescribeCdnData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeCdnDomainLogs 用于查询访问日志下载地址，仅支持 30 天以内的境内、境外访问日志下载链接查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnDomainLogsResponse>(req, "DescribeCdnDomainLogs");
        }

        /// <summary>
        /// DescribeCdnDomainLogs 用于查询访问日志下载地址，仅支持 30 天以内的境内、境外访问日志下载链接查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsSync(DescribeCdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeCdnDomainLogsResponse>(req, "DescribeCdnDomainLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeCdnIp 用于查询 CDN IP 归属。
        /// （注意：此接口请求频率限制以 CDN 侧限制为准：200次/10分钟）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public Task<DescribeCdnIpResponse> DescribeCdnIp(DescribeCdnIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnIpResponse>(req, "DescribeCdnIp");
        }

        /// <summary>
        /// DescribeCdnIp 用于查询 CDN IP 归属。
        /// （注意：此接口请求频率限制以 CDN 侧限制为准：200次/10分钟）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public DescribeCdnIpResponse DescribeCdnIpSync(DescribeCdnIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnIpResponse>(req, "DescribeCdnIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// 本接口（DescribeCdnOriginIp）用于查询 CDN 回源节点的IP信息。（注：替换接口为DescribeIpStatus）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public Task<DescribeCdnOriginIpResponse> DescribeCdnOriginIp(DescribeCdnOriginIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnOriginIpResponse>(req, "DescribeCdnOriginIp");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// 本接口（DescribeCdnOriginIp）用于查询 CDN 回源节点的IP信息。（注：替换接口为DescribeIpStatus）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public DescribeCdnOriginIpResponse DescribeCdnOriginIpSync(DescribeCdnOriginIpRequest req)
        {
            return InternalRequestAsync<DescribeCdnOriginIpResponse>(req, "DescribeCdnOriginIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeCertDomains 用于校验SSL证书并提取证书中包含的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public Task<DescribeCertDomainsResponse> DescribeCertDomains(DescribeCertDomainsRequest req)
        {
            return InternalRequestAsync<DescribeCertDomainsResponse>(req, "DescribeCertDomains");
        }

        /// <summary>
        /// DescribeCertDomains 用于校验SSL证书并提取证书中包含的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public DescribeCertDomainsResponse DescribeCertDomainsSync(DescribeCertDomainsRequest req)
        {
            return InternalRequestAsync<DescribeCertDomainsResponse>(req, "DescribeCertDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DDoS统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSDataResponse"/></returns>
        public Task<DescribeDDoSDataResponse> DescribeDDoSData(DescribeDDoSDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSDataResponse>(req, "DescribeDDoSData");
        }

        /// <summary>
        /// DDoS统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSDataResponse"/></returns>
        public DescribeDDoSDataResponse DescribeDDoSDataSync(DescribeDDoSDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSDataResponse>(req, "DescribeDDoSData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DescribeDiagnoseReport 用于获取指定报告id的内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseReportRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseReportResponse"/></returns>
        public Task<DescribeDiagnoseReportResponse> DescribeDiagnoseReport(DescribeDiagnoseReportRequest req)
        {
            return InternalRequestAsync<DescribeDiagnoseReportResponse>(req, "DescribeDiagnoseReport");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DescribeDiagnoseReport 用于获取指定报告id的内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseReportRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseReportResponse"/></returns>
        public DescribeDiagnoseReportResponse DescribeDiagnoseReportSync(DescribeDiagnoseReportRequest req)
        {
            return InternalRequestAsync<DescribeDiagnoseReportResponse>(req, "DescribeDiagnoseReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定域名的区域、运营商明细数据
        /// 注意事项：接口尚未全面开放，未在内测名单中的账号不支持调用
        /// </summary>
        /// <param name="req"><see cref="DescribeDistrictIspDataRequest"/></param>
        /// <returns><see cref="DescribeDistrictIspDataResponse"/></returns>
        public Task<DescribeDistrictIspDataResponse> DescribeDistrictIspData(DescribeDistrictIspDataRequest req)
        {
            return InternalRequestAsync<DescribeDistrictIspDataResponse>(req, "DescribeDistrictIspData");
        }

        /// <summary>
        /// 查询指定域名的区域、运营商明细数据
        /// 注意事项：接口尚未全面开放，未在内测名单中的账号不支持调用
        /// </summary>
        /// <param name="req"><see cref="DescribeDistrictIspDataRequest"/></param>
        /// <returns><see cref="DescribeDistrictIspDataResponse"/></returns>
        public DescribeDistrictIspDataResponse DescribeDistrictIspDataSync(DescribeDistrictIspDataRequest req)
        {
            return InternalRequestAsync<DescribeDistrictIspDataResponse>(req, "DescribeDistrictIspData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeDomains 用于查询内容分发网络加速域名（含境内、境外）基本配置信息，包括项目ID、服务状态，业务类型、创建时间、更新时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// DescribeDomains 用于查询内容分发网络加速域名（含境内、境外）基本配置信息，包括项目ID、服务状态，业务类型、创建时间、更新时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeDomainsConfig 用于查询内容分发网络加速域名（含境内、境外）的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public Task<DescribeDomainsConfigResponse> DescribeDomainsConfig(DescribeDomainsConfigRequest req)
        {
            return InternalRequestAsync<DescribeDomainsConfigResponse>(req, "DescribeDomainsConfig");
        }

        /// <summary>
        /// DescribeDomainsConfig 用于查询内容分发网络加速域名（含境内、境外）的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public DescribeDomainsConfigResponse DescribeDomainsConfigSync(DescribeDomainsConfigRequest req)
        {
            return InternalRequestAsync<DescribeDomainsConfigResponse>(req, "DescribeDomainsConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeEdgePackTaskStatus 用于查询动态打包任务状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePackTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgePackTaskStatusResponse"/></returns>
        public Task<DescribeEdgePackTaskStatusResponse> DescribeEdgePackTaskStatus(DescribeEdgePackTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeEdgePackTaskStatusResponse>(req, "DescribeEdgePackTaskStatus");
        }

        /// <summary>
        /// DescribeEdgePackTaskStatus 用于查询动态打包任务状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePackTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgePackTaskStatusResponse"/></returns>
        public DescribeEdgePackTaskStatusResponse DescribeEdgePackTaskStatusSync(DescribeEdgePackTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeEdgePackTaskStatusResponse>(req, "DescribeEdgePackTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeEventLogData 用于查询事件日志统计曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeEventLogDataRequest"/></param>
        /// <returns><see cref="DescribeEventLogDataResponse"/></returns>
        public Task<DescribeEventLogDataResponse> DescribeEventLogData(DescribeEventLogDataRequest req)
        {
            return InternalRequestAsync<DescribeEventLogDataResponse>(req, "DescribeEventLogData");
        }

        /// <summary>
        /// DescribeEventLogData 用于查询事件日志统计曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeEventLogDataRequest"/></param>
        /// <returns><see cref="DescribeEventLogDataResponse"/></returns>
        public DescribeEventLogDataResponse DescribeEventLogDataSync(DescribeEventLogDataRequest req)
        {
            return InternalRequestAsync<DescribeEventLogDataResponse>(req, "DescribeEventLogData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeHttpsPackages 用于查询 CDN HTTPS请求包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpsPackagesRequest"/></param>
        /// <returns><see cref="DescribeHttpsPackagesResponse"/></returns>
        public Task<DescribeHttpsPackagesResponse> DescribeHttpsPackages(DescribeHttpsPackagesRequest req)
        {
            return InternalRequestAsync<DescribeHttpsPackagesResponse>(req, "DescribeHttpsPackages");
        }

        /// <summary>
        /// DescribeHttpsPackages 用于查询 CDN HTTPS请求包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpsPackagesRequest"/></param>
        /// <returns><see cref="DescribeHttpsPackagesResponse"/></returns>
        public DescribeHttpsPackagesResponse DescribeHttpsPackagesSync(DescribeHttpsPackagesRequest req)
        {
            return InternalRequestAsync<DescribeHttpsPackagesResponse>(req, "DescribeHttpsPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeImageConfig 用于获取域名图片优化的当前配置，支持Webp、TPG、 Guetzli 和 Avif。 
        /// </summary>
        /// <param name="req"><see cref="DescribeImageConfigRequest"/></param>
        /// <returns><see cref="DescribeImageConfigResponse"/></returns>
        public Task<DescribeImageConfigResponse> DescribeImageConfig(DescribeImageConfigRequest req)
        {
            return InternalRequestAsync<DescribeImageConfigResponse>(req, "DescribeImageConfig");
        }

        /// <summary>
        /// DescribeImageConfig 用于获取域名图片优化的当前配置，支持Webp、TPG、 Guetzli 和 Avif。 
        /// </summary>
        /// <param name="req"><see cref="DescribeImageConfigRequest"/></param>
        /// <returns><see cref="DescribeImageConfigResponse"/></returns>
        public DescribeImageConfigResponse DescribeImageConfigSync(DescribeImageConfigRequest req)
        {
            return InternalRequestAsync<DescribeImageConfigResponse>(req, "DescribeImageConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的边缘节点、回源节点明细。注意事项：暂不支持查询边缘节点信息并且数据会存在一定延迟。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41954"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public Task<DescribeIpStatusResponse> DescribeIpStatus(DescribeIpStatusRequest req)
        {
            return InternalRequestAsync<DescribeIpStatusResponse>(req, "DescribeIpStatus");
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的边缘节点、回源节点明细。注意事项：暂不支持查询边缘节点信息并且数据会存在一定延迟。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41954"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public DescribeIpStatusResponse DescribeIpStatusSync(DescribeIpStatusRequest req)
        {
            return InternalRequestAsync<DescribeIpStatusResponse>(req, "DescribeIpStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeIpVisit 用于查询 5 分钟活跃用户数，及日活跃用户数明细
        /// 
        /// + 5 分钟活跃用户数：根据日志中客户端 IP，5 分钟粒度去重统计
        /// + 日活跃用户数：根据日志中客户端 IP，按天粒度去重统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public Task<DescribeIpVisitResponse> DescribeIpVisit(DescribeIpVisitRequest req)
        {
            return InternalRequestAsync<DescribeIpVisitResponse>(req, "DescribeIpVisit");
        }

        /// <summary>
        /// DescribeIpVisit 用于查询 5 分钟活跃用户数，及日活跃用户数明细
        /// 
        /// + 5 分钟活跃用户数：根据日志中客户端 IP，5 分钟粒度去重统计
        /// + 日活跃用户数：根据日志中客户端 IP，按天粒度去重统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public DescribeIpVisitResponse DescribeIpVisitSync(DescribeIpVisitRequest req)
        {
            return InternalRequestAsync<DescribeIpVisitResponse>(req, "DescribeIpVisit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeMapInfo 用于查询省份对应的 ID，运营商对应的 ID 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public Task<DescribeMapInfoResponse> DescribeMapInfo(DescribeMapInfoRequest req)
        {
            return InternalRequestAsync<DescribeMapInfoResponse>(req, "DescribeMapInfo");
        }

        /// <summary>
        /// DescribeMapInfo 用于查询省份对应的 ID，运营商对应的 ID 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public DescribeMapInfoResponse DescribeMapInfoSync(DescribeMapInfoRequest req)
        {
            return InternalRequestAsync<DescribeMapInfoResponse>(req, "DescribeMapInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeOriginDataResponse> DescribeOriginData(DescribeOriginDataRequest req)
        {
            return InternalRequestAsync<DescribeOriginDataResponse>(req, "DescribeOriginData");
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
        public DescribeOriginDataResponse DescribeOriginDataSync(DescribeOriginDataRequest req)
        {
            return InternalRequestAsync<DescribeOriginDataResponse>(req, "DescribeOriginData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePayType 用于查询用户的计费类型，计费周期等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public Task<DescribePayTypeResponse> DescribePayType(DescribePayTypeRequest req)
        {
            return InternalRequestAsync<DescribePayTypeResponse>(req, "DescribePayType");
        }

        /// <summary>
        /// DescribePayType 用于查询用户的计费类型，计费周期等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public DescribePayTypeResponse DescribePayTypeSync(DescribePayTypeRequest req)
        {
            return InternalRequestAsync<DescribePayTypeResponse>(req, "DescribePayType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePurgeQuota 用于查询账户刷新配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public Task<DescribePurgeQuotaResponse> DescribePurgeQuota(DescribePurgeQuotaRequest req)
        {
            return InternalRequestAsync<DescribePurgeQuotaResponse>(req, "DescribePurgeQuota");
        }

        /// <summary>
        /// DescribePurgeQuota 用于查询账户刷新配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public DescribePurgeQuotaResponse DescribePurgeQuotaSync(DescribePurgeQuotaRequest req)
        {
            return InternalRequestAsync<DescribePurgeQuotaResponse>(req, "DescribePurgeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 PurgePathCache 与 PurgeUrlsCache 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 PurgePathCache 与 PurgeUrlsCache 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePushQuota  用于查询预热配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public Task<DescribePushQuotaResponse> DescribePushQuota(DescribePushQuotaRequest req)
        {
            return InternalRequestAsync<DescribePushQuotaResponse>(req, "DescribePushQuota");
        }

        /// <summary>
        /// DescribePushQuota  用于查询预热配额和每日可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public DescribePushQuotaResponse DescribePushQuotaSync(DescribePushQuotaRequest req)
        {
            return InternalRequestAsync<DescribePushQuotaResponse>(req, "DescribePushQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePushTasks  用于查询预热任务提交历史记录及执行进度。
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public Task<DescribePushTasksResponse> DescribePushTasks(DescribePushTasksRequest req)
        {
            return InternalRequestAsync<DescribePushTasksResponse>(req, "DescribePushTasks");
        }

        /// <summary>
        /// DescribePushTasks  用于查询预热任务提交历史记录及执行进度。
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public DescribePushTasksResponse DescribePushTasksSync(DescribePushTasksRequest req)
        {
            return InternalRequestAsync<DescribePushTasksResponse>(req, "DescribePushTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeReportData 用于查询域名/项目维度的日/周/月报表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public Task<DescribeReportDataResponse> DescribeReportData(DescribeReportDataRequest req)
        {
            return InternalRequestAsync<DescribeReportDataResponse>(req, "DescribeReportData");
        }

        /// <summary>
        /// DescribeReportData 用于查询域名/项目维度的日/周/月报表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public DescribeReportDataResponse DescribeReportDataSync(DescribeReportDataRequest req)
        {
            return InternalRequestAsync<DescribeReportDataResponse>(req, "DescribeReportData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取BOT统计数据列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotDataRequest"/></param>
        /// <returns><see cref="DescribeScdnBotDataResponse"/></returns>
        public Task<DescribeScdnBotDataResponse> DescribeScdnBotData(DescribeScdnBotDataRequest req)
        {
            return InternalRequestAsync<DescribeScdnBotDataResponse>(req, "DescribeScdnBotData");
        }

        /// <summary>
        /// 获取BOT统计数据列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotDataRequest"/></param>
        /// <returns><see cref="DescribeScdnBotDataResponse"/></returns>
        public DescribeScdnBotDataResponse DescribeScdnBotDataSync(DescribeScdnBotDataRequest req)
        {
            return InternalRequestAsync<DescribeScdnBotDataResponse>(req, "DescribeScdnBotData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询BOT会话记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotRecordsRequest"/></param>
        /// <returns><see cref="DescribeScdnBotRecordsResponse"/></returns>
        public Task<DescribeScdnBotRecordsResponse> DescribeScdnBotRecords(DescribeScdnBotRecordsRequest req)
        {
            return InternalRequestAsync<DescribeScdnBotRecordsResponse>(req, "DescribeScdnBotRecords");
        }

        /// <summary>
        /// 查询BOT会话记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnBotRecordsRequest"/></param>
        /// <returns><see cref="DescribeScdnBotRecordsResponse"/></returns>
        public DescribeScdnBotRecordsResponse DescribeScdnBotRecordsSync(DescribeScdnBotRecordsRequest req)
        {
            return InternalRequestAsync<DescribeScdnBotRecordsResponse>(req, "DescribeScdnBotRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeScdnConfig 用于查询指定 SCDN 加速域名的安全相关配置
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnConfigRequest"/></param>
        /// <returns><see cref="DescribeScdnConfigResponse"/></returns>
        public Task<DescribeScdnConfigResponse> DescribeScdnConfig(DescribeScdnConfigRequest req)
        {
            return InternalRequestAsync<DescribeScdnConfigResponse>(req, "DescribeScdnConfig");
        }

        /// <summary>
        /// DescribeScdnConfig 用于查询指定 SCDN 加速域名的安全相关配置
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnConfigRequest"/></param>
        /// <returns><see cref="DescribeScdnConfigResponse"/></returns>
        public DescribeScdnConfigResponse DescribeScdnConfigSync(DescribeScdnConfigRequest req)
        {
            return InternalRequestAsync<DescribeScdnConfigResponse>(req, "DescribeScdnConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询在SCDN IP安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnIpStrategyRequest"/></param>
        /// <returns><see cref="DescribeScdnIpStrategyResponse"/></returns>
        public Task<DescribeScdnIpStrategyResponse> DescribeScdnIpStrategy(DescribeScdnIpStrategyRequest req)
        {
            return InternalRequestAsync<DescribeScdnIpStrategyResponse>(req, "DescribeScdnIpStrategy");
        }

        /// <summary>
        /// 查询在SCDN IP安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnIpStrategyRequest"/></param>
        /// <returns><see cref="DescribeScdnIpStrategyResponse"/></returns>
        public DescribeScdnIpStrategyResponse DescribeScdnIpStrategySync(DescribeScdnIpStrategyRequest req)
        {
            return InternalRequestAsync<DescribeScdnIpStrategyResponse>(req, "DescribeScdnIpStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取SCDN的Top数据
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnTopDataRequest"/></param>
        /// <returns><see cref="DescribeScdnTopDataResponse"/></returns>
        public Task<DescribeScdnTopDataResponse> DescribeScdnTopData(DescribeScdnTopDataRequest req)
        {
            return InternalRequestAsync<DescribeScdnTopDataResponse>(req, "DescribeScdnTopData");
        }

        /// <summary>
        /// 获取SCDN的Top数据
        /// </summary>
        /// <param name="req"><see cref="DescribeScdnTopDataRequest"/></param>
        /// <returns><see cref="DescribeScdnTopDataResponse"/></returns>
        public DescribeScdnTopDataResponse DescribeScdnTopDataSync(DescribeScdnTopDataRequest req)
        {
            return InternalRequestAsync<DescribeScdnTopDataResponse>(req, "DescribeScdnTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 IP 排序，从大至小返回 TOP 100 IP
        /// + 依据总流量、总请求数对访问 Refer 排序，从大至小返回 TOP 100 Refer
        /// + 依据总流量、总请求数对访问 设备 排序，从大至小返回 设备类型
        /// + 依据总流量、总请求数对访问 操作系统 排序，从大至小返回 操作系统
        /// + 依据总流量、总请求数对访问 浏览器 排序，从大至小返回 浏览器
        /// 
        /// 注意：
        /// + 仅支持 90 天内数据查询，且从2021年09月20日开始有数据
        /// + 本接口为beta版，尚未正式全量发布
        /// </summary>
        /// <param name="req"><see cref="DescribeTopDataRequest"/></param>
        /// <returns><see cref="DescribeTopDataResponse"/></returns>
        public Task<DescribeTopDataResponse> DescribeTopData(DescribeTopDataRequest req)
        {
            return InternalRequestAsync<DescribeTopDataResponse>(req, "DescribeTopData");
        }

        /// <summary>
        /// DescribeTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 IP 排序，从大至小返回 TOP 100 IP
        /// + 依据总流量、总请求数对访问 Refer 排序，从大至小返回 TOP 100 Refer
        /// + 依据总流量、总请求数对访问 设备 排序，从大至小返回 设备类型
        /// + 依据总流量、总请求数对访问 操作系统 排序，从大至小返回 操作系统
        /// + 依据总流量、总请求数对访问 浏览器 排序，从大至小返回 浏览器
        /// 
        /// 注意：
        /// + 仅支持 90 天内数据查询，且从2021年09月20日开始有数据
        /// + 本接口为beta版，尚未正式全量发布
        /// </summary>
        /// <param name="req"><see cref="DescribeTopDataRequest"/></param>
        /// <returns><see cref="DescribeTopDataResponse"/></returns>
        public DescribeTopDataResponse DescribeTopDataSync(DescribeTopDataRequest req)
        {
            return InternalRequestAsync<DescribeTopDataResponse>(req, "DescribeTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeTrafficPackages 用于查询 CDN 流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages");
        }

        /// <summary>
        /// DescribeTrafficPackages 用于查询 CDN 流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeUrlViolations 用于查询被 CDN 系统扫描到的域名违规 URL 列表及当前状态。
        /// 对应内容分发网络控制台【图片鉴黄】页面。
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public Task<DescribeUrlViolationsResponse> DescribeUrlViolations(DescribeUrlViolationsRequest req)
        {
            return InternalRequestAsync<DescribeUrlViolationsResponse>(req, "DescribeUrlViolations");
        }

        /// <summary>
        /// DescribeUrlViolations 用于查询被 CDN 系统扫描到的域名违规 URL 列表及当前状态。
        /// 对应内容分发网络控制台【图片鉴黄】页面。
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public DescribeUrlViolationsResponse DescribeUrlViolationsSync(DescribeUrlViolationsRequest req)
        {
            return InternalRequestAsync<DescribeUrlViolationsResponse>(req, "DescribeUrlViolations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDataRequest"/></param>
        /// <returns><see cref="DescribeWafDataResponse"/></returns>
        public Task<DescribeWafDataResponse> DescribeWafData(DescribeWafDataRequest req)
        {
            return InternalRequestAsync<DescribeWafDataResponse>(req, "DescribeWafData");
        }

        /// <summary>
        /// Waf统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDataRequest"/></param>
        /// <returns><see cref="DescribeWafDataResponse"/></returns>
        public DescribeWafDataResponse DescribeWafDataSync(DescribeWafDataRequest req)
        {
            return InternalRequestAsync<DescribeWafDataResponse>(req, "DescribeWafData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，中国境内访问会直接返回 403。
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public Task<DisableCachesResponse> DisableCaches(DisableCachesRequest req)
        {
            return InternalRequestAsync<DisableCachesResponse>(req, "DisableCaches");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，中国境内访问会直接返回 403。
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public DisableCachesResponse DisableCachesSync(DisableCachesRequest req)
        {
            return InternalRequestAsync<DisableCachesResponse>(req, "DisableCaches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DisableClsLogTopic 用于停止日志主题投递。注意：停止后，所有绑定该日志主题域名的日志将不再继续投递至该主题，已经投递的日志将会继续保留。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public Task<DisableClsLogTopicResponse> DisableClsLogTopic(DisableClsLogTopicRequest req)
        {
            return InternalRequestAsync<DisableClsLogTopicResponse>(req, "DisableClsLogTopic");
        }

        /// <summary>
        /// DisableClsLogTopic 用于停止日志主题投递。注意：停止后，所有绑定该日志主题域名的日志将不再继续投递至该主题，已经投递的日志将会继续保留。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public DisableClsLogTopicResponse DisableClsLogTopicSync(DisableClsLogTopicRequest req)
        {
            return InternalRequestAsync<DisableClsLogTopicResponse>(req, "DisableClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拷贝参考域名的配置至新域名。暂不支持自有证书以及定制化配置
        /// </summary>
        /// <param name="req"><see cref="DuplicateDomainConfigRequest"/></param>
        /// <returns><see cref="DuplicateDomainConfigResponse"/></returns>
        public Task<DuplicateDomainConfigResponse> DuplicateDomainConfig(DuplicateDomainConfigRequest req)
        {
            return InternalRequestAsync<DuplicateDomainConfigResponse>(req, "DuplicateDomainConfig");
        }

        /// <summary>
        /// 拷贝参考域名的配置至新域名。暂不支持自有证书以及定制化配置
        /// </summary>
        /// <param name="req"><see cref="DuplicateDomainConfigRequest"/></param>
        /// <returns><see cref="DuplicateDomainConfigResponse"/></returns>
        public DuplicateDomainConfigResponse DuplicateDomainConfigSync(DuplicateDomainConfigRequest req)
        {
            return InternalRequestAsync<DuplicateDomainConfigResponse>(req, "DuplicateDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public Task<EnableCachesResponse> EnableCaches(EnableCachesRequest req)
        {
            return InternalRequestAsync<EnableCachesResponse>(req, "EnableCaches");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public EnableCachesResponse EnableCachesSync(EnableCachesRequest req)
        {
            return InternalRequestAsync<EnableCachesResponse>(req, "EnableCaches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EnableClsLogTopic 用于启动日志主题投递。注意：启动后，所有绑定该日志主题域名的日志将继续投递至该主题。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public Task<EnableClsLogTopicResponse> EnableClsLogTopic(EnableClsLogTopicRequest req)
        {
            return InternalRequestAsync<EnableClsLogTopicResponse>(req, "EnableClsLogTopic");
        }

        /// <summary>
        /// EnableClsLogTopic 用于启动日志主题投递。注意：启动后，所有绑定该日志主题域名的日志将继续投递至该主题。生效时间约为 5~15 分钟。
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public EnableClsLogTopicResponse EnableClsLogTopicSync(EnableClsLogTopicRequest req)
        {
            return InternalRequestAsync<EnableClsLogTopicResponse>(req, "EnableClsLogTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// GetDisableRecords 用于查询资源禁用历史，及 URL 当前状态。
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public Task<GetDisableRecordsResponse> GetDisableRecords(GetDisableRecordsRequest req)
        {
            return InternalRequestAsync<GetDisableRecordsResponse>(req, "GetDisableRecords");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// GetDisableRecords 用于查询资源禁用历史，及 URL 当前状态。
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public GetDisableRecordsResponse GetDisableRecordsSync(GetDisableRecordsRequest req)
        {
            return InternalRequestAsync<GetDisableRecordsResponse>(req, "GetDisableRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ListClsLogTopics 用于显示日志主题列表。注意：一个日志集下至多含10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public Task<ListClsLogTopicsResponse> ListClsLogTopics(ListClsLogTopicsRequest req)
        {
            return InternalRequestAsync<ListClsLogTopicsResponse>(req, "ListClsLogTopics");
        }

        /// <summary>
        /// ListClsLogTopics 用于显示日志主题列表。注意：一个日志集下至多含10个日志主题。
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public ListClsLogTopicsResponse ListClsLogTopicsSync(ListClsLogTopicsRequest req)
        {
            return InternalRequestAsync<ListClsLogTopicsResponse>(req, "ListClsLogTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ListClsTopicDomains 用于获取某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public Task<ListClsTopicDomainsResponse> ListClsTopicDomains(ListClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ListClsTopicDomainsResponse>(req, "ListClsTopicDomains");
        }

        /// <summary>
        /// ListClsTopicDomains 用于获取某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public ListClsTopicDomainsResponse ListClsTopicDomainsSync(ListClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ListClsTopicDomainsResponse>(req, "ListClsTopicDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// ListDiagnoseReport 用于获取用户诊断URL访问后各个子任务的简要详情。
        /// </summary>
        /// <param name="req"><see cref="ListDiagnoseReportRequest"/></param>
        /// <returns><see cref="ListDiagnoseReportResponse"/></returns>
        public Task<ListDiagnoseReportResponse> ListDiagnoseReport(ListDiagnoseReportRequest req)
        {
            return InternalRequestAsync<ListDiagnoseReportResponse>(req, "ListDiagnoseReport");
        }

        /// <summary>
        /// ### <font color=red>**该接口已废弃** </font><br>
        /// ListDiagnoseReport 用于获取用户诊断URL访问后各个子任务的简要详情。
        /// </summary>
        /// <param name="req"><see cref="ListDiagnoseReportRequest"/></param>
        /// <returns><see cref="ListDiagnoseReportResponse"/></returns>
        public ListDiagnoseReportResponse ListDiagnoseReportSync(ListDiagnoseReportRequest req)
        {
            return InternalRequestAsync<ListDiagnoseReportResponse>(req, "ListDiagnoseReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ListScdnDomains 用于查询 SCDN 安全加速域名列表，及域名基本配置信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnDomainsRequest"/></param>
        /// <returns><see cref="ListScdnDomainsResponse"/></returns>
        public Task<ListScdnDomainsResponse> ListScdnDomains(ListScdnDomainsRequest req)
        {
            return InternalRequestAsync<ListScdnDomainsResponse>(req, "ListScdnDomains");
        }

        /// <summary>
        /// ListScdnDomains 用于查询 SCDN 安全加速域名列表，及域名基本配置信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnDomainsRequest"/></param>
        /// <returns><see cref="ListScdnDomainsResponse"/></returns>
        public ListScdnDomainsResponse ListScdnDomainsSync(ListScdnDomainsRequest req)
        {
            return InternalRequestAsync<ListScdnDomainsResponse>(req, "ListScdnDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ListScdnLogTasks 用于查询SCDN日志下载任务列表,以及展示下载任务基本信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnLogTasksRequest"/></param>
        /// <returns><see cref="ListScdnLogTasksResponse"/></returns>
        public Task<ListScdnLogTasksResponse> ListScdnLogTasks(ListScdnLogTasksRequest req)
        {
            return InternalRequestAsync<ListScdnLogTasksResponse>(req, "ListScdnLogTasks");
        }

        /// <summary>
        /// ListScdnLogTasks 用于查询SCDN日志下载任务列表,以及展示下载任务基本信息
        /// </summary>
        /// <param name="req"><see cref="ListScdnLogTasksRequest"/></param>
        /// <returns><see cref="ListScdnLogTasksResponse"/></returns>
        public ListScdnLogTasksResponse ListScdnLogTasksSync(ListScdnLogTasksRequest req)
        {
            return InternalRequestAsync<ListScdnLogTasksResponse>(req, "ListScdnLogTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Bot攻击的Top数据列表
        /// </summary>
        /// <param name="req"><see cref="ListScdnTopBotDataRequest"/></param>
        /// <returns><see cref="ListScdnTopBotDataResponse"/></returns>
        public Task<ListScdnTopBotDataResponse> ListScdnTopBotData(ListScdnTopBotDataRequest req)
        {
            return InternalRequestAsync<ListScdnTopBotDataResponse>(req, "ListScdnTopBotData");
        }

        /// <summary>
        /// 获取Bot攻击的Top数据列表
        /// </summary>
        /// <param name="req"><see cref="ListScdnTopBotDataRequest"/></param>
        /// <returns><see cref="ListScdnTopBotDataResponse"/></returns>
        public ListScdnTopBotDataResponse ListScdnTopBotDataSync(ListScdnTopBotDataRequest req)
        {
            return InternalRequestAsync<ListScdnTopBotDataResponse>(req, "ListScdnTopBotData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Bot攻击的Top信息
        /// </summary>
        /// <param name="req"><see cref="ListTopBotDataRequest"/></param>
        /// <returns><see cref="ListTopBotDataResponse"/></returns>
        public Task<ListTopBotDataResponse> ListTopBotData(ListTopBotDataRequest req)
        {
            return InternalRequestAsync<ListTopBotDataResponse>(req, "ListTopBotData");
        }

        /// <summary>
        /// 获取Bot攻击的Top信息
        /// </summary>
        /// <param name="req"><see cref="ListTopBotDataRequest"/></param>
        /// <returns><see cref="ListTopBotDataResponse"/></returns>
        public ListTopBotDataResponse ListTopBotDataSync(ListTopBotDataRequest req)
        {
            return InternalRequestAsync<ListTopBotDataResponse>(req, "ListTopBotData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopCcDataRequest"/></param>
        /// <returns><see cref="ListTopCcDataResponse"/></returns>
        public Task<ListTopCcDataResponse> ListTopCcData(ListTopCcDataRequest req)
        {
            return InternalRequestAsync<ListTopCcDataResponse>(req, "ListTopCcData");
        }

        /// <summary>
        /// 获取CC攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopCcDataRequest"/></param>
        /// <returns><see cref="ListTopCcDataResponse"/></returns>
        public ListTopCcDataResponse ListTopCcDataSync(ListTopCcDataRequest req)
        {
            return InternalRequestAsync<ListTopCcDataResponse>(req, "ListTopCcData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过CLS日志计算Top信息。支持近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="ListTopClsLogDataRequest"/></param>
        /// <returns><see cref="ListTopClsLogDataResponse"/></returns>
        public Task<ListTopClsLogDataResponse> ListTopClsLogData(ListTopClsLogDataRequest req)
        {
            return InternalRequestAsync<ListTopClsLogDataResponse>(req, "ListTopClsLogData");
        }

        /// <summary>
        /// 通过CLS日志计算Top信息。支持近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="ListTopClsLogDataRequest"/></param>
        /// <returns><see cref="ListTopClsLogDataResponse"/></returns>
        public ListTopClsLogDataResponse ListTopClsLogDataSync(ListTopClsLogDataRequest req)
        {
            return InternalRequestAsync<ListTopClsLogDataResponse>(req, "ListTopClsLogData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopDDoSDataRequest"/></param>
        /// <returns><see cref="ListTopDDoSDataResponse"/></returns>
        public Task<ListTopDDoSDataResponse> ListTopDDoSData(ListTopDDoSDataRequest req)
        {
            return InternalRequestAsync<ListTopDDoSDataResponse>(req, "ListTopDDoSData");
        }

        /// <summary>
        /// 获取DDoS攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopDDoSDataRequest"/></param>
        /// <returns><see cref="ListTopDDoSDataResponse"/></returns>
        public ListTopDDoSDataResponse ListTopDDoSDataSync(ListTopDDoSDataRequest req)
        {
            return InternalRequestAsync<ListTopDDoSDataResponse>(req, "ListTopDDoSData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ListTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 URL 排序，从大至小返回 TOP 1000 URL
        /// + 依据总流量、总请求数对客户端省份排序，从大至小返回省份列表
        /// + 依据总流量、总请求数对客户端运营商排序，从大至小返回运营商列表
        /// + 依据总流量、峰值带宽、总请求数、平均命中率、2XX/3XX/4XX/5XX 状态码对域名排序，从大至小返回域名列表
        /// + 依据总回源流量、回源峰值带宽、总回源请求数、平均回源失败率、2XX/3XX/4XX/5XX 回源状态码对域名排序，从大至小返回域名列表
        /// 
        /// 注意：仅支持 90 天内数据查询
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public Task<ListTopDataResponse> ListTopData(ListTopDataRequest req)
        {
            return InternalRequestAsync<ListTopDataResponse>(req, "ListTopData");
        }

        /// <summary>
        /// ListTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 URL 排序，从大至小返回 TOP 1000 URL
        /// + 依据总流量、总请求数对客户端省份排序，从大至小返回省份列表
        /// + 依据总流量、总请求数对客户端运营商排序，从大至小返回运营商列表
        /// + 依据总流量、峰值带宽、总请求数、平均命中率、2XX/3XX/4XX/5XX 状态码对域名排序，从大至小返回域名列表
        /// + 依据总回源流量、回源峰值带宽、总回源请求数、平均回源失败率、2XX/3XX/4XX/5XX 回源状态码对域名排序，从大至小返回域名列表
        /// 
        /// 注意：仅支持 90 天内数据查询
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public ListTopDataResponse ListTopDataSync(ListTopDataRequest req)
        {
            return InternalRequestAsync<ListTopDataResponse>(req, "ListTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Waf攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopWafDataRequest"/></param>
        /// <returns><see cref="ListTopWafDataResponse"/></returns>
        public Task<ListTopWafDataResponse> ListTopWafData(ListTopWafDataRequest req)
        {
            return InternalRequestAsync<ListTopWafDataResponse>(req, "ListTopWafData");
        }

        /// <summary>
        /// 获取Waf攻击Top数据
        /// </summary>
        /// <param name="req"><see cref="ListTopWafDataRequest"/></param>
        /// <returns><see cref="ListTopWafDataResponse"/></returns>
        public ListTopWafDataResponse ListTopWafDataSync(ListTopWafDataRequest req)
        {
            return InternalRequestAsync<ListTopWafDataResponse>(req, "ListTopWafData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ManageClsTopicDomains 用于管理某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public Task<ManageClsTopicDomainsResponse> ManageClsTopicDomains(ManageClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ManageClsTopicDomainsResponse>(req, "ManageClsTopicDomains");
        }

        /// <summary>
        /// ManageClsTopicDomains 用于管理某日志主题下绑定的域名列表。
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public ManageClsTopicDomainsResponse ManageClsTopicDomainsSync(ManageClsTopicDomainsRequest req)
        {
            return InternalRequestAsync<ManageClsTopicDomainsResponse>(req, "ManageClsTopicDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyDomainConfig 用于修改内容分发网络加速域名配置信息
        /// 注意：
        /// Route 字段，使用点分隔，最后一段称为叶子节点，非叶子节点配置保持不变；
        /// Value 字段，使用 json 进行序列化，其中固定 update 作为 key，配置路径值参考 https://cloud.tencent.com/document/product/228/41116 接口各配置项复杂类型，为配置路径对应复杂类型下的节点。
        /// 操作审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到操作审计。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyDomainConfigResponse"/></returns>
        public Task<ModifyDomainConfigResponse> ModifyDomainConfig(ModifyDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyDomainConfigResponse>(req, "ModifyDomainConfig");
        }

        /// <summary>
        /// ModifyDomainConfig 用于修改内容分发网络加速域名配置信息
        /// 注意：
        /// Route 字段，使用点分隔，最后一段称为叶子节点，非叶子节点配置保持不变；
        /// Value 字段，使用 json 进行序列化，其中固定 update 作为 key，配置路径值参考 https://cloud.tencent.com/document/product/228/41116 接口各配置项复杂类型，为配置路径对应复杂类型下的节点。
        /// 操作审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到操作审计。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyDomainConfigResponse"/></returns>
        public ModifyDomainConfigResponse ModifyDomainConfigSync(ModifyDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyDomainConfigResponse>(req, "ModifyDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyPurgeFetchTaskStatus 用于上报定时刷新预热任务执行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyPurgeFetchTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyPurgeFetchTaskStatusResponse"/></returns>
        public Task<ModifyPurgeFetchTaskStatusResponse> ModifyPurgeFetchTaskStatus(ModifyPurgeFetchTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyPurgeFetchTaskStatusResponse>(req, "ModifyPurgeFetchTaskStatus");
        }

        /// <summary>
        /// ModifyPurgeFetchTaskStatus 用于上报定时刷新预热任务执行状态
        /// </summary>
        /// <param name="req"><see cref="ModifyPurgeFetchTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyPurgeFetchTaskStatusResponse"/></returns>
        public ModifyPurgeFetchTaskStatusResponse ModifyPurgeFetchTaskStatusSync(ModifyPurgeFetchTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyPurgeFetchTaskStatusResponse>(req, "ModifyPurgeFetchTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 500 条。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
            return InternalRequestAsync<PurgePathCacheResponse>(req, "PurgePathCache");
        }

        /// <summary>
        /// PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 500 条。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
            return InternalRequestAsync<PurgePathCacheResponse>(req, "PurgePathCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量提交 URL 进行刷新，根据 URL 中域名的当前加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日 URL 刷新额度各为 10000 条，每次最多可提交 1000 条。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public Task<PurgeUrlsCacheResponse> PurgeUrlsCache(PurgeUrlsCacheRequest req)
        {
            return InternalRequestAsync<PurgeUrlsCacheResponse>(req, "PurgeUrlsCache");
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量提交 URL 进行刷新，根据 URL 中域名的当前加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日 URL 刷新额度各为 10000 条，每次最多可提交 1000 条。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public PurgeUrlsCacheResponse PurgeUrlsCacheSync(PurgeUrlsCacheRequest req)
        {
            return InternalRequestAsync<PurgeUrlsCacheResponse>(req, "PurgeUrlsCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// PushUrlsCache 用于将指定 URL 资源列表加载至 CDN 节点，支持指定加速区域预热。
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 500 条 URL，每次提交的数量会消耗配额总数。如：1次提交500条URL全球预热，此时境内、境外预热 URL 各剩余 500条。注意：中国境外区域预热，资源默认加载至中国境外边缘节点。
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public Task<PushUrlsCacheResponse> PushUrlsCache(PushUrlsCacheRequest req)
        {
            return InternalRequestAsync<PushUrlsCacheResponse>(req, "PushUrlsCache");
        }

        /// <summary>
        /// PushUrlsCache 用于将指定 URL 资源列表加载至 CDN 节点，支持指定加速区域预热。
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 500 条 URL，每次提交的数量会消耗配额总数。如：1次提交500条URL全球预热，此时境内、境外预热 URL 各剩余 500条。注意：中国境外区域预热，资源默认加载至中国境外边缘节点。
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public PushUrlsCacheResponse PushUrlsCacheSync(PushUrlsCacheRequest req)
        {
            return InternalRequestAsync<PushUrlsCacheResponse>(req, "PushUrlsCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SearchClsLog 用于 CLS 日志检索。支持检索今天，24小时（可选近7中的某一天），近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public Task<SearchClsLogResponse> SearchClsLog(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog");
        }

        /// <summary>
        /// SearchClsLog 用于 CLS 日志检索。支持检索今天，24小时（可选近7中的某一天），近7天的日志数据。
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public SearchClsLogResponse SearchClsLogSync(SearchClsLogRequest req)
        {
            return InternalRequestAsync<SearchClsLogResponse>(req, "SearchClsLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// StartCdnDomain 用于启用已停用域名的加速服务
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public Task<StartCdnDomainResponse> StartCdnDomain(StartCdnDomainRequest req)
        {
            return InternalRequestAsync<StartCdnDomainResponse>(req, "StartCdnDomain");
        }

        /// <summary>
        /// StartCdnDomain 用于启用已停用域名的加速服务
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public StartCdnDomainResponse StartCdnDomainSync(StartCdnDomainRequest req)
        {
            return InternalRequestAsync<StartCdnDomainResponse>(req, "StartCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// StartScdnDomain 用于开启域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StartScdnDomainRequest"/></param>
        /// <returns><see cref="StartScdnDomainResponse"/></returns>
        public Task<StartScdnDomainResponse> StartScdnDomain(StartScdnDomainRequest req)
        {
            return InternalRequestAsync<StartScdnDomainResponse>(req, "StartScdnDomain");
        }

        /// <summary>
        /// StartScdnDomain 用于开启域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StartScdnDomainRequest"/></param>
        /// <returns><see cref="StartScdnDomainResponse"/></returns>
        public StartScdnDomainResponse StartScdnDomainSync(StartScdnDomainRequest req)
        {
            return InternalRequestAsync<StartScdnDomainResponse>(req, "StartScdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// StopCdnDomain 用于停止域名的加速服务。
        /// 注意：停止加速服务后，访问至加速节点的请求将会直接返回 404。为避免对您的业务造成影响，请在停止加速服务前将解析切走。
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public Task<StopCdnDomainResponse> StopCdnDomain(StopCdnDomainRequest req)
        {
            return InternalRequestAsync<StopCdnDomainResponse>(req, "StopCdnDomain");
        }

        /// <summary>
        /// StopCdnDomain 用于停止域名的加速服务。
        /// 注意：停止加速服务后，访问至加速节点的请求将会直接返回 404。为避免对您的业务造成影响，请在停止加速服务前将解析切走。
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public StopCdnDomainResponse StopCdnDomainSync(StopCdnDomainRequest req)
        {
            return InternalRequestAsync<StopCdnDomainResponse>(req, "StopCdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// StopScdnDomain 用于关闭域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StopScdnDomainRequest"/></param>
        /// <returns><see cref="StopScdnDomainResponse"/></returns>
        public Task<StopScdnDomainResponse> StopScdnDomain(StopScdnDomainRequest req)
        {
            return InternalRequestAsync<StopScdnDomainResponse>(req, "StopScdnDomain");
        }

        /// <summary>
        /// StopScdnDomain 用于关闭域名的安全防护配置
        /// </summary>
        /// <param name="req"><see cref="StopScdnDomainRequest"/></param>
        /// <returns><see cref="StopScdnDomainResponse"/></returns>
        public StopScdnDomainResponse StopScdnDomainSync(StopScdnDomainRequest req)
        {
            return InternalRequestAsync<StopScdnDomainResponse>(req, "StopScdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// UpdateDomainConfig 用于修改内容分发网络加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值，建议通过查询接口获取配置属性后，直接修改后传递给本接口。
        /// 操作审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到操作审计。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public Task<UpdateDomainConfigResponse> UpdateDomainConfig(UpdateDomainConfigRequest req)
        {
            return InternalRequestAsync<UpdateDomainConfigResponse>(req, "UpdateDomainConfig");
        }

        /// <summary>
        /// UpdateDomainConfig 用于修改内容分发网络加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值，建议通过查询接口获取配置属性后，直接修改后传递给本接口。
        /// 操作审计相关：接口的入参可能包含密钥等敏感信息，所以此接口的入参不会上报到操作审计。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public UpdateDomainConfigResponse UpdateDomainConfigSync(UpdateDomainConfigRequest req)
        {
            return InternalRequestAsync<UpdateDomainConfigResponse>(req, "UpdateDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// UpdateImageConfig 用于更新控制台图片优化的相关配置，支持Webp、TPG、 Guetzli 和 Avif。 
        /// </summary>
        /// <param name="req"><see cref="UpdateImageConfigRequest"/></param>
        /// <returns><see cref="UpdateImageConfigResponse"/></returns>
        public Task<UpdateImageConfigResponse> UpdateImageConfig(UpdateImageConfigRequest req)
        {
            return InternalRequestAsync<UpdateImageConfigResponse>(req, "UpdateImageConfig");
        }

        /// <summary>
        /// UpdateImageConfig 用于更新控制台图片优化的相关配置，支持Webp、TPG、 Guetzli 和 Avif。 
        /// </summary>
        /// <param name="req"><see cref="UpdateImageConfigRequest"/></param>
        /// <returns><see cref="UpdateImageConfigResponse"/></returns>
        public UpdateImageConfigResponse UpdateImageConfigSync(UpdateImageConfigRequest req)
        {
            return InternalRequestAsync<UpdateImageConfigResponse>(req, "UpdateImageConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpdatePayType)用于修改账号计费类型，暂不支持月结用户或子账号修改。
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public Task<UpdatePayTypeResponse> UpdatePayType(UpdatePayTypeRequest req)
        {
            return InternalRequestAsync<UpdatePayTypeResponse>(req, "UpdatePayType");
        }

        /// <summary>
        /// 本接口(UpdatePayType)用于修改账号计费类型，暂不支持月结用户或子账号修改。
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public UpdatePayTypeResponse UpdatePayTypeSync(UpdatePayTypeRequest req)
        {
            return InternalRequestAsync<UpdatePayTypeResponse>(req, "UpdatePayType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// UpdateScdnDomain 用于修改 SCDN 加速域名安全相关配置
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public Task<UpdateScdnDomainResponse> UpdateScdnDomain(UpdateScdnDomainRequest req)
        {
            return InternalRequestAsync<UpdateScdnDomainResponse>(req, "UpdateScdnDomain");
        }

        /// <summary>
        /// UpdateScdnDomain 用于修改 SCDN 加速域名安全相关配置
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public UpdateScdnDomainResponse UpdateScdnDomainSync(UpdateScdnDomainRequest req)
        {
            return InternalRequestAsync<UpdateScdnDomainResponse>(req, "UpdateScdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// VerifyDomainRecord 用于验证域名解析值。
        /// 验证域名解析记录值前，您需要通过 [CreateVerifyRecord](https://cloud.tencent.com/document/product/228/48118) 生成校验解析值，验证通过后，24小时有效。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public Task<VerifyDomainRecordResponse> VerifyDomainRecord(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord");
        }

        /// <summary>
        /// VerifyDomainRecord 用于验证域名解析值。
        /// 验证域名解析记录值前，您需要通过 [CreateVerifyRecord](https://cloud.tencent.com/document/product/228/48118) 生成校验解析值，验证通过后，24小时有效。
        /// 具体流程可参考：[使用API接口进行域名归属校验](https://cloud.tencent.com/document/product/228/61702#.E6.96.B9.E6.B3.95.E4.B8.89.EF.BC.9Aapi-.E6.8E.A5.E5.8F.A3.E6.93.8D.E4.BD.9C)
        /// </summary>
        /// <param name="req"><see cref="VerifyDomainRecordRequest"/></param>
        /// <returns><see cref="VerifyDomainRecordResponse"/></returns>
        public VerifyDomainRecordResponse VerifyDomainRecordSync(VerifyDomainRecordRequest req)
        {
            return InternalRequestAsync<VerifyDomainRecordResponse>(req, "VerifyDomainRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

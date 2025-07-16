/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ctem.V20231128
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ctem.V20231128.Models;

   public class CtemClient : AbstractClient{

       private const string endpoint = "ctem.tencentcloudapi.com";
       private const string version = "2023-11-28";
       private const string sdkVersion = "SDK_NET_3.0.1281";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CtemClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CtemClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建企业
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerRequest"/></param>
        /// <returns><see cref="CreateCustomerResponse"/></returns>
        public Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest req)
        {
            return InternalRequestAsync<CreateCustomerResponse>(req, "CreateCustomer");
        }

        /// <summary>
        /// 创建企业
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerRequest"/></param>
        /// <returns><see cref="CreateCustomerResponse"/></returns>
        public CreateCustomerResponse CreateCustomerSync(CreateCustomerRequest req)
        {
            return InternalRequestAsync<CreateCustomerResponse>(req, "CreateCustomer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动测绘
        /// </summary>
        /// <param name="req"><see cref="CreateJobRecordRequest"/></param>
        /// <returns><see cref="CreateJobRecordResponse"/></returns>
        public Task<CreateJobRecordResponse> CreateJobRecord(CreateJobRecordRequest req)
        {
            return InternalRequestAsync<CreateJobRecordResponse>(req, "CreateJobRecord");
        }

        /// <summary>
        /// 启动测绘
        /// </summary>
        /// <param name="req"><see cref="CreateJobRecordRequest"/></param>
        /// <returns><see cref="CreateJobRecordResponse"/></returns>
        public CreateJobRecordResponse CreateJobRecordSync(CreateJobRecordRequest req)
        {
            return InternalRequestAsync<CreateJobRecordResponse>(req, "CreateJobRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看移动端资产
        /// </summary>
        /// <param name="req"><see cref="DescribeAppsRequest"/></param>
        /// <returns><see cref="DescribeAppsResponse"/></returns>
        public Task<DescribeAppsResponse> DescribeApps(DescribeAppsRequest req)
        {
            return InternalRequestAsync<DescribeAppsResponse>(req, "DescribeApps");
        }

        /// <summary>
        /// 查看移动端资产
        /// </summary>
        /// <param name="req"><see cref="DescribeAppsRequest"/></param>
        /// <returns><see cref="DescribeAppsResponse"/></returns>
        public DescribeAppsResponse DescribeAppsSync(DescribeAppsRequest req)
        {
            return InternalRequestAsync<DescribeAppsResponse>(req, "DescribeApps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看主机资产
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsRequest"/></param>
        /// <returns><see cref="DescribeAssetsResponse"/></returns>
        public Task<DescribeAssetsResponse> DescribeAssets(DescribeAssetsRequest req)
        {
            return InternalRequestAsync<DescribeAssetsResponse>(req, "DescribeAssets");
        }

        /// <summary>
        /// 查看主机资产
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsRequest"/></param>
        /// <returns><see cref="DescribeAssetsResponse"/></returns>
        public DescribeAssetsResponse DescribeAssetsSync(DescribeAssetsRequest req)
        {
            return InternalRequestAsync<DescribeAssetsResponse>(req, "DescribeAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看目录爆破数据
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs");
        }

        /// <summary>
        /// 查看目录爆破数据
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看企业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomersRequest"/></param>
        /// <returns><see cref="DescribeCustomersResponse"/></returns>
        public Task<DescribeCustomersResponse> DescribeCustomers(DescribeCustomersRequest req)
        {
            return InternalRequestAsync<DescribeCustomersResponse>(req, "DescribeCustomers");
        }

        /// <summary>
        /// 查看企业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomersRequest"/></param>
        /// <returns><see cref="DescribeCustomersResponse"/></returns>
        public DescribeCustomersResponse DescribeCustomersSync(DescribeCustomersRequest req)
        {
            return InternalRequestAsync<DescribeCustomersResponse>(req, "DescribeCustomers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看暗网数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDarkWebsRequest"/></param>
        /// <returns><see cref="DescribeDarkWebsResponse"/></returns>
        public Task<DescribeDarkWebsResponse> DescribeDarkWebs(DescribeDarkWebsRequest req)
        {
            return InternalRequestAsync<DescribeDarkWebsResponse>(req, "DescribeDarkWebs");
        }

        /// <summary>
        /// 查看暗网数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDarkWebsRequest"/></param>
        /// <returns><see cref="DescribeDarkWebsResponse"/></returns>
        public DescribeDarkWebsResponse DescribeDarkWebsSync(DescribeDarkWebsRequest req)
        {
            return InternalRequestAsync<DescribeDarkWebsResponse>(req, "DescribeDarkWebs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看主域名数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// 查看主域名数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看企业架构数据
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterprisesRequest"/></param>
        /// <returns><see cref="DescribeEnterprisesResponse"/></returns>
        public Task<DescribeEnterprisesResponse> DescribeEnterprises(DescribeEnterprisesRequest req)
        {
            return InternalRequestAsync<DescribeEnterprisesResponse>(req, "DescribeEnterprises");
        }

        /// <summary>
        /// 查看企业架构数据
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterprisesRequest"/></param>
        /// <returns><see cref="DescribeEnterprisesResponse"/></returns>
        public DescribeEnterprisesResponse DescribeEnterprisesSync(DescribeEnterprisesRequest req)
        {
            return InternalRequestAsync<DescribeEnterprisesResponse>(req, "DescribeEnterprises")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒应用
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeAppsRequest"/></param>
        /// <returns><see cref="DescribeFakeAppsResponse"/></returns>
        public Task<DescribeFakeAppsResponse> DescribeFakeApps(DescribeFakeAppsRequest req)
        {
            return InternalRequestAsync<DescribeFakeAppsResponse>(req, "DescribeFakeApps");
        }

        /// <summary>
        /// 查询仿冒应用
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeAppsRequest"/></param>
        /// <returns><see cref="DescribeFakeAppsResponse"/></returns>
        public DescribeFakeAppsResponse DescribeFakeAppsSync(DescribeFakeAppsRequest req)
        {
            return InternalRequestAsync<DescribeFakeAppsResponse>(req, "DescribeFakeApps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒小程序
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeMiniProgramsRequest"/></param>
        /// <returns><see cref="DescribeFakeMiniProgramsResponse"/></returns>
        public Task<DescribeFakeMiniProgramsResponse> DescribeFakeMiniPrograms(DescribeFakeMiniProgramsRequest req)
        {
            return InternalRequestAsync<DescribeFakeMiniProgramsResponse>(req, "DescribeFakeMiniPrograms");
        }

        /// <summary>
        /// 查询仿冒小程序
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeMiniProgramsRequest"/></param>
        /// <returns><see cref="DescribeFakeMiniProgramsResponse"/></returns>
        public DescribeFakeMiniProgramsResponse DescribeFakeMiniProgramsSync(DescribeFakeMiniProgramsRequest req)
        {
            return InternalRequestAsync<DescribeFakeMiniProgramsResponse>(req, "DescribeFakeMiniPrograms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒网站
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeWebsitesRequest"/></param>
        /// <returns><see cref="DescribeFakeWebsitesResponse"/></returns>
        public Task<DescribeFakeWebsitesResponse> DescribeFakeWebsites(DescribeFakeWebsitesRequest req)
        {
            return InternalRequestAsync<DescribeFakeWebsitesResponse>(req, "DescribeFakeWebsites");
        }

        /// <summary>
        /// 查询仿冒网站
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeWebsitesRequest"/></param>
        /// <returns><see cref="DescribeFakeWebsitesResponse"/></returns>
        public DescribeFakeWebsitesResponse DescribeFakeWebsitesSync(DescribeFakeWebsitesRequest req)
        {
            return InternalRequestAsync<DescribeFakeWebsitesResponse>(req, "DescribeFakeWebsites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒公众号
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeWechatOfficialsRequest"/></param>
        /// <returns><see cref="DescribeFakeWechatOfficialsResponse"/></returns>
        public Task<DescribeFakeWechatOfficialsResponse> DescribeFakeWechatOfficials(DescribeFakeWechatOfficialsRequest req)
        {
            return InternalRequestAsync<DescribeFakeWechatOfficialsResponse>(req, "DescribeFakeWechatOfficials");
        }

        /// <summary>
        /// 查询仿冒公众号
        /// </summary>
        /// <param name="req"><see cref="DescribeFakeWechatOfficialsRequest"/></param>
        /// <returns><see cref="DescribeFakeWechatOfficialsResponse"/></returns>
        public DescribeFakeWechatOfficialsResponse DescribeFakeWechatOfficialsSync(DescribeFakeWechatOfficialsRequest req)
        {
            return InternalRequestAsync<DescribeFakeWechatOfficialsResponse>(req, "DescribeFakeWechatOfficials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看Github泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGithubsRequest"/></param>
        /// <returns><see cref="DescribeGithubsResponse"/></returns>
        public Task<DescribeGithubsResponse> DescribeGithubs(DescribeGithubsRequest req)
        {
            return InternalRequestAsync<DescribeGithubsResponse>(req, "DescribeGithubs");
        }

        /// <summary>
        /// 查看Github泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeGithubsRequest"/></param>
        /// <returns><see cref="DescribeGithubsResponse"/></returns>
        public DescribeGithubsResponse DescribeGithubsSync(DescribeGithubsRequest req)
        {
            return InternalRequestAsync<DescribeGithubsResponse>(req, "DescribeGithubs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看http数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpsRequest"/></param>
        /// <returns><see cref="DescribeHttpsResponse"/></returns>
        public Task<DescribeHttpsResponse> DescribeHttps(DescribeHttpsRequest req)
        {
            return InternalRequestAsync<DescribeHttpsResponse>(req, "DescribeHttps");
        }

        /// <summary>
        /// 查看http数据
        /// </summary>
        /// <param name="req"><see cref="DescribeHttpsRequest"/></param>
        /// <returns><see cref="DescribeHttpsResponse"/></returns>
        public DescribeHttpsResponse DescribeHttpsSync(DescribeHttpsRequest req)
        {
            return InternalRequestAsync<DescribeHttpsResponse>(req, "DescribeHttps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看链路详情
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRecordDetailsRequest"/></param>
        /// <returns><see cref="DescribeJobRecordDetailsResponse"/></returns>
        public Task<DescribeJobRecordDetailsResponse> DescribeJobRecordDetails(DescribeJobRecordDetailsRequest req)
        {
            return InternalRequestAsync<DescribeJobRecordDetailsResponse>(req, "DescribeJobRecordDetails");
        }

        /// <summary>
        /// 查看链路详情
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRecordDetailsRequest"/></param>
        /// <returns><see cref="DescribeJobRecordDetailsResponse"/></returns>
        public DescribeJobRecordDetailsResponse DescribeJobRecordDetailsSync(DescribeJobRecordDetailsRequest req)
        {
            return InternalRequestAsync<DescribeJobRecordDetailsResponse>(req, "DescribeJobRecordDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看任务运行记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRecordsRequest"/></param>
        /// <returns><see cref="DescribeJobRecordsResponse"/></returns>
        public Task<DescribeJobRecordsResponse> DescribeJobRecords(DescribeJobRecordsRequest req)
        {
            return InternalRequestAsync<DescribeJobRecordsResponse>(req, "DescribeJobRecords");
        }

        /// <summary>
        /// 查看任务运行记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRecordsRequest"/></param>
        /// <returns><see cref="DescribeJobRecordsResponse"/></returns>
        public DescribeJobRecordsResponse DescribeJobRecordsSync(DescribeJobRecordsRequest req)
        {
            return InternalRequestAsync<DescribeJobRecordsResponse>(req, "DescribeJobRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取代码泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakageCodesRequest"/></param>
        /// <returns><see cref="DescribeLeakageCodesResponse"/></returns>
        public Task<DescribeLeakageCodesResponse> DescribeLeakageCodes(DescribeLeakageCodesRequest req)
        {
            return InternalRequestAsync<DescribeLeakageCodesResponse>(req, "DescribeLeakageCodes");
        }

        /// <summary>
        /// 获取代码泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakageCodesRequest"/></param>
        /// <returns><see cref="DescribeLeakageCodesResponse"/></returns>
        public DescribeLeakageCodesResponse DescribeLeakageCodesSync(DescribeLeakageCodesRequest req)
        {
            return InternalRequestAsync<DescribeLeakageCodesResponse>(req, "DescribeLeakageCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据泄露事件
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakageDatasRequest"/></param>
        /// <returns><see cref="DescribeLeakageDatasResponse"/></returns>
        public Task<DescribeLeakageDatasResponse> DescribeLeakageDatas(DescribeLeakageDatasRequest req)
        {
            return InternalRequestAsync<DescribeLeakageDatasResponse>(req, "DescribeLeakageDatas");
        }

        /// <summary>
        /// 获取数据泄露事件
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakageDatasRequest"/></param>
        /// <returns><see cref="DescribeLeakageDatasResponse"/></returns>
        public DescribeLeakageDatasResponse DescribeLeakageDatasSync(DescribeLeakageDatasRequest req)
        {
            return InternalRequestAsync<DescribeLeakageDatasResponse>(req, "DescribeLeakageDatas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取邮箱泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakageEmailsRequest"/></param>
        /// <returns><see cref="DescribeLeakageEmailsResponse"/></returns>
        public Task<DescribeLeakageEmailsResponse> DescribeLeakageEmails(DescribeLeakageEmailsRequest req)
        {
            return InternalRequestAsync<DescribeLeakageEmailsResponse>(req, "DescribeLeakageEmails");
        }

        /// <summary>
        /// 获取邮箱泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakageEmailsRequest"/></param>
        /// <returns><see cref="DescribeLeakageEmailsResponse"/></returns>
        public DescribeLeakageEmailsResponse DescribeLeakageEmailsSync(DescribeLeakageEmailsRequest req)
        {
            return InternalRequestAsync<DescribeLeakageEmailsResponse>(req, "DescribeLeakageEmails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看后台管理数据
        /// </summary>
        /// <param name="req"><see cref="DescribeManagesRequest"/></param>
        /// <returns><see cref="DescribeManagesResponse"/></returns>
        public Task<DescribeManagesResponse> DescribeManages(DescribeManagesRequest req)
        {
            return InternalRequestAsync<DescribeManagesResponse>(req, "DescribeManages");
        }

        /// <summary>
        /// 查看后台管理数据
        /// </summary>
        /// <param name="req"><see cref="DescribeManagesRequest"/></param>
        /// <returns><see cref="DescribeManagesResponse"/></returns>
        public DescribeManagesResponse DescribeManagesSync(DescribeManagesRequest req)
        {
            return InternalRequestAsync<DescribeManagesResponse>(req, "DescribeManages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看网盘泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDisksRequest"/></param>
        /// <returns><see cref="DescribeNetDisksResponse"/></returns>
        public Task<DescribeNetDisksResponse> DescribeNetDisks(DescribeNetDisksRequest req)
        {
            return InternalRequestAsync<DescribeNetDisksResponse>(req, "DescribeNetDisks");
        }

        /// <summary>
        /// 查看网盘泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDisksRequest"/></param>
        /// <returns><see cref="DescribeNetDisksResponse"/></returns>
        public DescribeNetDisksResponse DescribeNetDisksSync(DescribeNetDisksRequest req)
        {
            return InternalRequestAsync<DescribeNetDisksResponse>(req, "DescribeNetDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看端口数据
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public Task<DescribePortsResponse> DescribePorts(DescribePortsRequest req)
        {
            return InternalRequestAsync<DescribePortsResponse>(req, "DescribePorts");
        }

        /// <summary>
        /// 查看端口数据
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public DescribePortsResponse DescribePortsSync(DescribePortsRequest req)
        {
            return InternalRequestAsync<DescribePortsResponse>(req, "DescribePorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看敏感信息泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveInfosRequest"/></param>
        /// <returns><see cref="DescribeSensitiveInfosResponse"/></returns>
        public Task<DescribeSensitiveInfosResponse> DescribeSensitiveInfos(DescribeSensitiveInfosRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveInfosResponse>(req, "DescribeSensitiveInfos");
        }

        /// <summary>
        /// 查看敏感信息泄露数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveInfosRequest"/></param>
        /// <returns><see cref="DescribeSensitiveInfosResponse"/></returns>
        public DescribeSensitiveInfosResponse DescribeSensitiveInfosSync(DescribeSensitiveInfosRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveInfosResponse>(req, "DescribeSensitiveInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看子域名数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeSubDomainsResponse"/></returns>
        public Task<DescribeSubDomainsResponse> DescribeSubDomains(DescribeSubDomainsRequest req)
        {
            return InternalRequestAsync<DescribeSubDomainsResponse>(req, "DescribeSubDomains");
        }

        /// <summary>
        /// 查看子域名数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeSubDomainsResponse"/></returns>
        public DescribeSubDomainsResponse DescribeSubDomainsSync(DescribeSubDomainsRequest req)
        {
            return InternalRequestAsync<DescribeSubDomainsResponse>(req, "DescribeSubDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看影子资产
        /// </summary>
        /// <param name="req"><see cref="DescribeSuspiciousAssetsRequest"/></param>
        /// <returns><see cref="DescribeSuspiciousAssetsResponse"/></returns>
        public Task<DescribeSuspiciousAssetsResponse> DescribeSuspiciousAssets(DescribeSuspiciousAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSuspiciousAssetsResponse>(req, "DescribeSuspiciousAssets");
        }

        /// <summary>
        /// 查看影子资产
        /// </summary>
        /// <param name="req"><see cref="DescribeSuspiciousAssetsRequest"/></param>
        /// <returns><see cref="DescribeSuspiciousAssetsResponse"/></returns>
        public DescribeSuspiciousAssetsResponse DescribeSuspiciousAssetsSync(DescribeSuspiciousAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSuspiciousAssetsResponse>(req, "DescribeSuspiciousAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看漏洞数据
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls");
        }

        /// <summary>
        /// 查看漏洞数据
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public DescribeVulsResponse DescribeVulsSync(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看弱口令数据
        /// </summary>
        /// <param name="req"><see cref="DescribeWeakPasswordsRequest"/></param>
        /// <returns><see cref="DescribeWeakPasswordsResponse"/></returns>
        public Task<DescribeWeakPasswordsResponse> DescribeWeakPasswords(DescribeWeakPasswordsRequest req)
        {
            return InternalRequestAsync<DescribeWeakPasswordsResponse>(req, "DescribeWeakPasswords");
        }

        /// <summary>
        /// 查看弱口令数据
        /// </summary>
        /// <param name="req"><see cref="DescribeWeakPasswordsRequest"/></param>
        /// <returns><see cref="DescribeWeakPasswordsResponse"/></returns>
        public DescribeWeakPasswordsResponse DescribeWeakPasswordsSync(DescribeWeakPasswordsRequest req)
        {
            return InternalRequestAsync<DescribeWeakPasswordsResponse>(req, "DescribeWeakPasswords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看微信小程序
        /// </summary>
        /// <param name="req"><see cref="DescribeWechatAppletsRequest"/></param>
        /// <returns><see cref="DescribeWechatAppletsResponse"/></returns>
        public Task<DescribeWechatAppletsResponse> DescribeWechatApplets(DescribeWechatAppletsRequest req)
        {
            return InternalRequestAsync<DescribeWechatAppletsResponse>(req, "DescribeWechatApplets");
        }

        /// <summary>
        /// 查看微信小程序
        /// </summary>
        /// <param name="req"><see cref="DescribeWechatAppletsRequest"/></param>
        /// <returns><see cref="DescribeWechatAppletsResponse"/></returns>
        public DescribeWechatAppletsResponse DescribeWechatAppletsSync(DescribeWechatAppletsRequest req)
        {
            return InternalRequestAsync<DescribeWechatAppletsResponse>(req, "DescribeWechatApplets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看公众号数据
        /// </summary>
        /// <param name="req"><see cref="DescribeWechatOfficialAccountsRequest"/></param>
        /// <returns><see cref="DescribeWechatOfficialAccountsResponse"/></returns>
        public Task<DescribeWechatOfficialAccountsResponse> DescribeWechatOfficialAccounts(DescribeWechatOfficialAccountsRequest req)
        {
            return InternalRequestAsync<DescribeWechatOfficialAccountsResponse>(req, "DescribeWechatOfficialAccounts");
        }

        /// <summary>
        /// 查看公众号数据
        /// </summary>
        /// <param name="req"><see cref="DescribeWechatOfficialAccountsRequest"/></param>
        /// <returns><see cref="DescribeWechatOfficialAccountsResponse"/></returns>
        public DescribeWechatOfficialAccountsResponse DescribeWechatOfficialAccountsSync(DescribeWechatOfficialAccountsRequest req)
        {
            return InternalRequestAsync<DescribeWechatOfficialAccountsResponse>(req, "DescribeWechatOfficialAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑企业
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerRequest"/></param>
        /// <returns><see cref="ModifyCustomerResponse"/></returns>
        public Task<ModifyCustomerResponse> ModifyCustomer(ModifyCustomerRequest req)
        {
            return InternalRequestAsync<ModifyCustomerResponse>(req, "ModifyCustomer");
        }

        /// <summary>
        /// 编辑企业
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerRequest"/></param>
        /// <returns><see cref="ModifyCustomerResponse"/></returns>
        public ModifyCustomerResponse ModifyCustomerSync(ModifyCustomerRequest req)
        {
            return InternalRequestAsync<ModifyCustomerResponse>(req, "ModifyCustomer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止扫描
        /// </summary>
        /// <param name="req"><see cref="StopJobRecordRequest"/></param>
        /// <returns><see cref="StopJobRecordResponse"/></returns>
        public Task<StopJobRecordResponse> StopJobRecord(StopJobRecordRequest req)
        {
            return InternalRequestAsync<StopJobRecordResponse>(req, "StopJobRecord");
        }

        /// <summary>
        /// 停止扫描
        /// </summary>
        /// <param name="req"><see cref="StopJobRecordRequest"/></param>
        /// <returns><see cref="StopJobRecordResponse"/></returns>
        public StopJobRecordResponse StopJobRecordSync(StopJobRecordRequest req)
        {
            return InternalRequestAsync<StopJobRecordResponse>(req, "StopJobRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

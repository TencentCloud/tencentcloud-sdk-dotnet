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

namespace TencentCloud.Sslpod.V20190605
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sslpod.V20190605.Models;

   public class SslpodClient : AbstractClient{

       private const string endpoint = "sslpod.tencentcloudapi.com";
       private const string version = "2019-06-05";
       private const string sdkVersion = "SDK_NET_3.0.1090";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SslpodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SslpodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通过域名端口添加监控
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain");
        }

        /// <summary>
        /// 通过域名端口添加监控
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过域名ID删除监控的域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain");
        }

        /// <summary>
        /// 通过域名ID删除监控的域名
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取仪表盘数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public Task<DescribeDashboardResponse> DescribeDashboard(DescribeDashboardRequest req)
        {
            return InternalRequestAsync<DescribeDashboardResponse>(req, "DescribeDashboard");
        }

        /// <summary>
        /// 获取仪表盘数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public DescribeDashboardResponse DescribeDashboardSync(DescribeDashboardRequest req)
        {
            return InternalRequestAsync<DescribeDashboardResponse>(req, "DescribeDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取域名关联证书
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCertsRequest"/></param>
        /// <returns><see cref="DescribeDomainCertsResponse"/></returns>
        public Task<DescribeDomainCertsResponse> DescribeDomainCerts(DescribeDomainCertsRequest req)
        {
            return InternalRequestAsync<DescribeDomainCertsResponse>(req, "DescribeDomainCerts");
        }

        /// <summary>
        /// 获取域名关联证书
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCertsRequest"/></param>
        /// <returns><see cref="DescribeDomainCertsResponse"/></returns>
        public DescribeDomainCertsResponse DescribeDomainCertsSync(DescribeDomainCertsRequest req)
        {
            return InternalRequestAsync<DescribeDomainCertsResponse>(req, "DescribeDomainCerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号下所有tag
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainTagsRequest"/></param>
        /// <returns><see cref="DescribeDomainTagsResponse"/></returns>
        public Task<DescribeDomainTagsResponse> DescribeDomainTags(DescribeDomainTagsRequest req)
        {
            return InternalRequestAsync<DescribeDomainTagsResponse>(req, "DescribeDomainTags");
        }

        /// <summary>
        /// 获取账号下所有tag
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainTagsRequest"/></param>
        /// <returns><see cref="DescribeDomainTagsResponse"/></returns>
        public DescribeDomainTagsResponse DescribeDomainTagsSync(DescribeDomainTagsRequest req)
        {
            return InternalRequestAsync<DescribeDomainTagsResponse>(req, "DescribeDomainTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过searchType搜索已经添加的域名
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// 通过searchType搜索已经添加的域名
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取通知额度信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeInfoRequest"/></param>
        /// <returns><see cref="DescribeNoticeInfoResponse"/></returns>
        public Task<DescribeNoticeInfoResponse> DescribeNoticeInfo(DescribeNoticeInfoRequest req)
        {
            return InternalRequestAsync<DescribeNoticeInfoResponse>(req, "DescribeNoticeInfo");
        }

        /// <summary>
        /// 获取通知额度信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeInfoRequest"/></param>
        /// <returns><see cref="DescribeNoticeInfoResponse"/></returns>
        public DescribeNoticeInfoResponse DescribeNoticeInfoSync(DescribeNoticeInfoRequest req)
        {
            return InternalRequestAsync<DescribeNoticeInfoResponse>(req, "DescribeNoticeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改域名tag
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainTagsRequest"/></param>
        /// <returns><see cref="ModifyDomainTagsResponse"/></returns>
        public Task<ModifyDomainTagsResponse> ModifyDomainTags(ModifyDomainTagsRequest req)
        {
            return InternalRequestAsync<ModifyDomainTagsResponse>(req, "ModifyDomainTags");
        }

        /// <summary>
        /// 修改域名tag
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainTagsRequest"/></param>
        /// <returns><see cref="ModifyDomainTagsResponse"/></returns>
        public ModifyDomainTagsResponse ModifyDomainTagsSync(ModifyDomainTagsRequest req)
        {
            return InternalRequestAsync<ModifyDomainTagsResponse>(req, "ModifyDomainTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 强制重新检测域名
        /// </summary>
        /// <param name="req"><see cref="RefreshDomainRequest"/></param>
        /// <returns><see cref="RefreshDomainResponse"/></returns>
        public Task<RefreshDomainResponse> RefreshDomain(RefreshDomainRequest req)
        {
            return InternalRequestAsync<RefreshDomainResponse>(req, "RefreshDomain");
        }

        /// <summary>
        /// 强制重新检测域名
        /// </summary>
        /// <param name="req"><see cref="RefreshDomainRequest"/></param>
        /// <returns><see cref="RefreshDomainResponse"/></returns>
        public RefreshDomainResponse RefreshDomainSync(RefreshDomainRequest req)
        {
            return InternalRequestAsync<RefreshDomainResponse>(req, "RefreshDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解析域名获得多个IP地址
        /// </summary>
        /// <param name="req"><see cref="ResolveDomainRequest"/></param>
        /// <returns><see cref="ResolveDomainResponse"/></returns>
        public Task<ResolveDomainResponse> ResolveDomain(ResolveDomainRequest req)
        {
            return InternalRequestAsync<ResolveDomainResponse>(req, "ResolveDomain");
        }

        /// <summary>
        /// 解析域名获得多个IP地址
        /// </summary>
        /// <param name="req"><see cref="ResolveDomainRequest"/></param>
        /// <returns><see cref="ResolveDomainResponse"/></returns>
        public ResolveDomainResponse ResolveDomainSync(ResolveDomainRequest req)
        {
            return InternalRequestAsync<ResolveDomainResponse>(req, "ResolveDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

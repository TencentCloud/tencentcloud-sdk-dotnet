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

namespace TencentCloud.Cws.V20180312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cws.V20180312.Models;

   public class CwsClient : AbstractClient{

       private const string endpoint = "cws.tencentcloudapi.com";
       private const string version = "2018-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1243";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CwsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CwsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（CreateMonitors）用于新增一个或多个站点的监测任务。
        /// </summary>
        /// <param name="req"><see cref="CreateMonitorsRequest"/></param>
        /// <returns><see cref="CreateMonitorsResponse"/></returns>
        public Task<CreateMonitorsResponse> CreateMonitors(CreateMonitorsRequest req)
        {
            return InternalRequestAsync<CreateMonitorsResponse>(req, "CreateMonitors");
        }

        /// <summary>
        /// 本接口（CreateMonitors）用于新增一个或多个站点的监测任务。
        /// </summary>
        /// <param name="req"><see cref="CreateMonitorsRequest"/></param>
        /// <returns><see cref="CreateMonitorsResponse"/></returns>
        public CreateMonitorsResponse CreateMonitorsSync(CreateMonitorsRequest req)
        {
            return InternalRequestAsync<CreateMonitorsResponse>(req, "CreateMonitors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSites）用于新增一个或多个站点。
        /// </summary>
        /// <param name="req"><see cref="CreateSitesRequest"/></param>
        /// <returns><see cref="CreateSitesResponse"/></returns>
        public Task<CreateSitesResponse> CreateSites(CreateSitesRequest req)
        {
            return InternalRequestAsync<CreateSitesResponse>(req, "CreateSites");
        }

        /// <summary>
        /// 本接口（CreateSites）用于新增一个或多个站点。
        /// </summary>
        /// <param name="req"><see cref="CreateSitesRequest"/></param>
        /// <returns><see cref="CreateSitesResponse"/></returns>
        public CreateSitesResponse CreateSitesSync(CreateSitesRequest req)
        {
            return InternalRequestAsync<CreateSitesResponse>(req, "CreateSites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSitesScans）用于新增一个或多个站点的单次扫描任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSitesScansRequest"/></param>
        /// <returns><see cref="CreateSitesScansResponse"/></returns>
        public Task<CreateSitesScansResponse> CreateSitesScans(CreateSitesScansRequest req)
        {
            return InternalRequestAsync<CreateSitesScansResponse>(req, "CreateSitesScans");
        }

        /// <summary>
        /// 本接口（CreateSitesScans）用于新增一个或多个站点的单次扫描任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSitesScansRequest"/></param>
        /// <returns><see cref="CreateSitesScansResponse"/></returns>
        public CreateSitesScansResponse CreateSitesScansSync(CreateSitesScansRequest req)
        {
            return InternalRequestAsync<CreateSitesScansResponse>(req, "CreateSitesScans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVulsMisinformation）可以用于新增一个或多个漏洞误报信息。
        /// </summary>
        /// <param name="req"><see cref="CreateVulsMisinformationRequest"/></param>
        /// <returns><see cref="CreateVulsMisinformationResponse"/></returns>
        public Task<CreateVulsMisinformationResponse> CreateVulsMisinformation(CreateVulsMisinformationRequest req)
        {
            return InternalRequestAsync<CreateVulsMisinformationResponse>(req, "CreateVulsMisinformation");
        }

        /// <summary>
        /// 本接口（CreateVulsMisinformation）可以用于新增一个或多个漏洞误报信息。
        /// </summary>
        /// <param name="req"><see cref="CreateVulsMisinformationRequest"/></param>
        /// <returns><see cref="CreateVulsMisinformationResponse"/></returns>
        public CreateVulsMisinformationResponse CreateVulsMisinformationSync(CreateVulsMisinformationRequest req)
        {
            return InternalRequestAsync<CreateVulsMisinformationResponse>(req, "CreateVulsMisinformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateVulsReport) 用于生成漏洞报告并返回下载链接。
        /// </summary>
        /// <param name="req"><see cref="CreateVulsReportRequest"/></param>
        /// <returns><see cref="CreateVulsReportResponse"/></returns>
        public Task<CreateVulsReportResponse> CreateVulsReport(CreateVulsReportRequest req)
        {
            return InternalRequestAsync<CreateVulsReportResponse>(req, "CreateVulsReport");
        }

        /// <summary>
        /// 本接口 (CreateVulsReport) 用于生成漏洞报告并返回下载链接。
        /// </summary>
        /// <param name="req"><see cref="CreateVulsReportRequest"/></param>
        /// <returns><see cref="CreateVulsReportResponse"/></returns>
        public CreateVulsReportResponse CreateVulsReportSync(CreateVulsReportRequest req)
        {
            return InternalRequestAsync<CreateVulsReportResponse>(req, "CreateVulsReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteMonitors) 用于删除用户监控任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteMonitorsRequest"/></param>
        /// <returns><see cref="DeleteMonitorsResponse"/></returns>
        public Task<DeleteMonitorsResponse> DeleteMonitors(DeleteMonitorsRequest req)
        {
            return InternalRequestAsync<DeleteMonitorsResponse>(req, "DeleteMonitors");
        }

        /// <summary>
        /// 本接口 (DeleteMonitors) 用于删除用户监控任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteMonitorsRequest"/></param>
        /// <returns><see cref="DeleteMonitorsResponse"/></returns>
        public DeleteMonitorsResponse DeleteMonitorsSync(DeleteMonitorsRequest req)
        {
            return InternalRequestAsync<DeleteMonitorsResponse>(req, "DeleteMonitors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteSites) 用于删除站点。
        /// </summary>
        /// <param name="req"><see cref="DeleteSitesRequest"/></param>
        /// <returns><see cref="DeleteSitesResponse"/></returns>
        public Task<DeleteSitesResponse> DeleteSites(DeleteSitesRequest req)
        {
            return InternalRequestAsync<DeleteSitesResponse>(req, "DeleteSites");
        }

        /// <summary>
        /// 本接口 (DeleteSites) 用于删除站点。
        /// </summary>
        /// <param name="req"><see cref="DeleteSitesRequest"/></param>
        /// <returns><see cref="DeleteSitesResponse"/></returns>
        public DeleteSitesResponse DeleteSitesSync(DeleteSitesRequest req)
        {
            return InternalRequestAsync<DeleteSitesResponse>(req, "DeleteSites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeConfig) 用于查询用户配置的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig");
        }

        /// <summary>
        /// 本接口 (DescribeConfig) 用于查询用户配置的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeMonitors) 用于查询一个或多个监控任务的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsRequest"/></param>
        /// <returns><see cref="DescribeMonitorsResponse"/></returns>
        public Task<DescribeMonitorsResponse> DescribeMonitors(DescribeMonitorsRequest req)
        {
            return InternalRequestAsync<DescribeMonitorsResponse>(req, "DescribeMonitors");
        }

        /// <summary>
        /// 本接口 (DescribeMonitors) 用于查询一个或多个监控任务的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsRequest"/></param>
        /// <returns><see cref="DescribeMonitorsResponse"/></returns>
        public DescribeMonitorsResponse DescribeMonitorsSync(DescribeMonitorsRequest req)
        {
            return InternalRequestAsync<DescribeMonitorsResponse>(req, "DescribeMonitors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeSiteQuota) 用于查询用户购买的扫描次数总数和已使用数。
        /// </summary>
        /// <param name="req"><see cref="DescribeSiteQuotaRequest"/></param>
        /// <returns><see cref="DescribeSiteQuotaResponse"/></returns>
        public Task<DescribeSiteQuotaResponse> DescribeSiteQuota(DescribeSiteQuotaRequest req)
        {
            return InternalRequestAsync<DescribeSiteQuotaResponse>(req, "DescribeSiteQuota");
        }

        /// <summary>
        /// 本接口 (DescribeSiteQuota) 用于查询用户购买的扫描次数总数和已使用数。
        /// </summary>
        /// <param name="req"><see cref="DescribeSiteQuotaRequest"/></param>
        /// <returns><see cref="DescribeSiteQuotaResponse"/></returns>
        public DescribeSiteQuotaResponse DescribeSiteQuotaSync(DescribeSiteQuotaRequest req)
        {
            return InternalRequestAsync<DescribeSiteQuotaResponse>(req, "DescribeSiteQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeSites) 用于查询一个或多个站点的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesRequest"/></param>
        /// <returns><see cref="DescribeSitesResponse"/></returns>
        public Task<DescribeSitesResponse> DescribeSites(DescribeSitesRequest req)
        {
            return InternalRequestAsync<DescribeSitesResponse>(req, "DescribeSites");
        }

        /// <summary>
        /// 本接口 (DescribeSites) 用于查询一个或多个站点的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesRequest"/></param>
        /// <returns><see cref="DescribeSitesResponse"/></returns>
        public DescribeSitesResponse DescribeSitesSync(DescribeSitesRequest req)
        {
            return InternalRequestAsync<DescribeSitesResponse>(req, "DescribeSites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeSitesVerification) 用于查询一个或多个待验证站点的验证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesVerificationRequest"/></param>
        /// <returns><see cref="DescribeSitesVerificationResponse"/></returns>
        public Task<DescribeSitesVerificationResponse> DescribeSitesVerification(DescribeSitesVerificationRequest req)
        {
            return InternalRequestAsync<DescribeSitesVerificationResponse>(req, "DescribeSitesVerification");
        }

        /// <summary>
        /// 本接口 (DescribeSitesVerification) 用于查询一个或多个待验证站点的验证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSitesVerificationRequest"/></param>
        /// <returns><see cref="DescribeSitesVerificationResponse"/></returns>
        public DescribeSitesVerificationResponse DescribeSitesVerificationSync(DescribeSitesVerificationRequest req)
        {
            return InternalRequestAsync<DescribeSitesVerificationResponse>(req, "DescribeSitesVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于查询一个或多个漏洞的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls");
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于查询一个或多个漏洞的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public DescribeVulsResponse DescribeVulsSync(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeVulsNumber) 用于查询用户网站的漏洞总计数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsNumberRequest"/></param>
        /// <returns><see cref="DescribeVulsNumberResponse"/></returns>
        public Task<DescribeVulsNumberResponse> DescribeVulsNumber(DescribeVulsNumberRequest req)
        {
            return InternalRequestAsync<DescribeVulsNumberResponse>(req, "DescribeVulsNumber");
        }

        /// <summary>
        /// 本接口 (DescribeVulsNumber) 用于查询用户网站的漏洞总计数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsNumberRequest"/></param>
        /// <returns><see cref="DescribeVulsNumberResponse"/></returns>
        public DescribeVulsNumberResponse DescribeVulsNumberSync(DescribeVulsNumberRequest req)
        {
            return InternalRequestAsync<DescribeVulsNumberResponse>(req, "DescribeVulsNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeVulsNumberTimeline) 用于查询漏洞数随时间变化统计信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsNumberTimelineRequest"/></param>
        /// <returns><see cref="DescribeVulsNumberTimelineResponse"/></returns>
        public Task<DescribeVulsNumberTimelineResponse> DescribeVulsNumberTimeline(DescribeVulsNumberTimelineRequest req)
        {
            return InternalRequestAsync<DescribeVulsNumberTimelineResponse>(req, "DescribeVulsNumberTimeline");
        }

        /// <summary>
        /// 本接口 (DescribeVulsNumberTimeline) 用于查询漏洞数随时间变化统计信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsNumberTimelineRequest"/></param>
        /// <returns><see cref="DescribeVulsNumberTimelineResponse"/></returns>
        public DescribeVulsNumberTimelineResponse DescribeVulsNumberTimelineSync(DescribeVulsNumberTimelineRequest req)
        {
            return InternalRequestAsync<DescribeVulsNumberTimelineResponse>(req, "DescribeVulsNumberTimeline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyConfigAttribute) 用于修改用户配置的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigAttributeRequest"/></param>
        /// <returns><see cref="ModifyConfigAttributeResponse"/></returns>
        public Task<ModifyConfigAttributeResponse> ModifyConfigAttribute(ModifyConfigAttributeRequest req)
        {
            return InternalRequestAsync<ModifyConfigAttributeResponse>(req, "ModifyConfigAttribute");
        }

        /// <summary>
        /// 本接口 (ModifyConfigAttribute) 用于修改用户配置的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigAttributeRequest"/></param>
        /// <returns><see cref="ModifyConfigAttributeResponse"/></returns>
        public ModifyConfigAttributeResponse ModifyConfigAttributeSync(ModifyConfigAttributeRequest req)
        {
            return InternalRequestAsync<ModifyConfigAttributeResponse>(req, "ModifyConfigAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyMonitorAttribute) 用于修改监测任务的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorAttributeRequest"/></param>
        /// <returns><see cref="ModifyMonitorAttributeResponse"/></returns>
        public Task<ModifyMonitorAttributeResponse> ModifyMonitorAttribute(ModifyMonitorAttributeRequest req)
        {
            return InternalRequestAsync<ModifyMonitorAttributeResponse>(req, "ModifyMonitorAttribute");
        }

        /// <summary>
        /// 本接口 (ModifyMonitorAttribute) 用于修改监测任务的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorAttributeRequest"/></param>
        /// <returns><see cref="ModifyMonitorAttributeResponse"/></returns>
        public ModifyMonitorAttributeResponse ModifyMonitorAttributeSync(ModifyMonitorAttributeRequest req)
        {
            return InternalRequestAsync<ModifyMonitorAttributeResponse>(req, "ModifyMonitorAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifySiteAttribute) 用于修改站点的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifySiteAttributeRequest"/></param>
        /// <returns><see cref="ModifySiteAttributeResponse"/></returns>
        public Task<ModifySiteAttributeResponse> ModifySiteAttribute(ModifySiteAttributeRequest req)
        {
            return InternalRequestAsync<ModifySiteAttributeResponse>(req, "ModifySiteAttribute");
        }

        /// <summary>
        /// 本接口 (ModifySiteAttribute) 用于修改站点的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifySiteAttributeRequest"/></param>
        /// <returns><see cref="ModifySiteAttributeResponse"/></returns>
        public ModifySiteAttributeResponse ModifySiteAttributeSync(ModifySiteAttributeRequest req)
        {
            return InternalRequestAsync<ModifySiteAttributeResponse>(req, "ModifySiteAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (VerifySites) 用于验证一个或多个待验证站点。
        /// </summary>
        /// <param name="req"><see cref="VerifySitesRequest"/></param>
        /// <returns><see cref="VerifySitesResponse"/></returns>
        public Task<VerifySitesResponse> VerifySites(VerifySitesRequest req)
        {
            return InternalRequestAsync<VerifySitesResponse>(req, "VerifySites");
        }

        /// <summary>
        /// 本接口 (VerifySites) 用于验证一个或多个待验证站点。
        /// </summary>
        /// <param name="req"><see cref="VerifySitesRequest"/></param>
        /// <returns><see cref="VerifySitesResponse"/></returns>
        public VerifySitesResponse VerifySitesSync(VerifySitesRequest req)
        {
            return InternalRequestAsync<VerifySitesResponse>(req, "VerifySites")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

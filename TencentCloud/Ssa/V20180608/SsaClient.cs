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

namespace TencentCloud.Ssa.V20180608
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssa.V20180608.Models;

   public class SsaClient : AbstractClient{

       private const string endpoint = "ssa.tencentcloudapi.com";
       private const string version = "2018-06-08";
       private const string sdkVersion = "SDK_NET_3.0.1089";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SsaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SsaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 安全大屏-用户威胁告警信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmStatRequest"/></param>
        /// <returns><see cref="DescribeAlarmStatResponse"/></returns>
        public Task<DescribeAlarmStatResponse> DescribeAlarmStat(DescribeAlarmStatRequest req)
        {
            return InternalRequestAsync<DescribeAlarmStatResponse>(req, "DescribeAlarmStat");
        }

        /// <summary>
        /// 安全大屏-用户威胁告警信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmStatRequest"/></param>
        /// <returns><see cref="DescribeAlarmStatResponse"/></returns>
        public DescribeAlarmStatResponse DescribeAlarmStatSync(DescribeAlarmStatRequest req)
        {
            return InternalRequestAsync<DescribeAlarmStatResponse>(req, "DescribeAlarmStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产安全页资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public Task<DescribeAssetDetailResponse> DescribeAssetDetail(DescribeAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailResponse>(req, "DescribeAssetDetail");
        }

        /// <summary>
        /// 资产安全页资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public DescribeAssetDetailResponse DescribeAssetDetailSync(DescribeAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailResponse>(req, "DescribeAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产条件查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailListRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailListResponse"/></returns>
        public Task<DescribeAssetDetailListResponse> DescribeAssetDetailList(DescribeAssetDetailListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailListResponse>(req, "DescribeAssetDetailList");
        }

        /// <summary>
        /// 资产条件查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailListRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailListResponse"/></returns>
        public DescribeAssetDetailListResponse DescribeAssetDetailListSync(DescribeAssetDetailListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailListResponse>(req, "DescribeAssetDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产安全资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetListRequest"/></param>
        /// <returns><see cref="DescribeAssetListResponse"/></returns>
        public Task<DescribeAssetListResponse> DescribeAssetList(DescribeAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAssetListResponse>(req, "DescribeAssetList");
        }

        /// <summary>
        /// 资产安全资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetListRequest"/></param>
        /// <returns><see cref="DescribeAssetListResponse"/></returns>
        public DescribeAssetListResponse DescribeAssetListSync(DescribeAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAssetListResponse>(req, "DescribeAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云安全配置管理资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigAssetListRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigAssetListResponse"/></returns>
        public Task<DescribeCheckConfigAssetListResponse> DescribeCheckConfigAssetList(DescribeCheckConfigAssetListRequest req)
        {
            return InternalRequestAsync<DescribeCheckConfigAssetListResponse>(req, "DescribeCheckConfigAssetList");
        }

        /// <summary>
        /// 云安全配置管理资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigAssetListRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigAssetListResponse"/></returns>
        public DescribeCheckConfigAssetListResponse DescribeCheckConfigAssetListSync(DescribeCheckConfigAssetListRequest req)
        {
            return InternalRequestAsync<DescribeCheckConfigAssetListResponse>(req, "DescribeCheckConfigAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云安全配置检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigDetailRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigDetailResponse"/></returns>
        public Task<DescribeCheckConfigDetailResponse> DescribeCheckConfigDetail(DescribeCheckConfigDetailRequest req)
        {
            return InternalRequestAsync<DescribeCheckConfigDetailResponse>(req, "DescribeCheckConfigDetail");
        }

        /// <summary>
        /// 云安全配置检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConfigDetailRequest"/></param>
        /// <returns><see cref="DescribeCheckConfigDetailResponse"/></returns>
        public DescribeCheckConfigDetailResponse DescribeCheckConfigDetailSync(DescribeCheckConfigDetailRequest req)
        {
            return InternalRequestAsync<DescribeCheckConfigDetailResponse>(req, "DescribeCheckConfigDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合规管理-资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetListResponse"/></returns>
        public Task<DescribeComplianceAssetListResponse> DescribeComplianceAssetList(DescribeComplianceAssetListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetListResponse>(req, "DescribeComplianceAssetList");
        }

        /// <summary>
        /// 合规管理-资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetListResponse"/></returns>
        public DescribeComplianceAssetListResponse DescribeComplianceAssetListSync(DescribeComplianceAssetListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetListResponse>(req, "DescribeComplianceAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合规管理检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceDetailRequest"/></param>
        /// <returns><see cref="DescribeComplianceDetailResponse"/></returns>
        public Task<DescribeComplianceDetailResponse> DescribeComplianceDetail(DescribeComplianceDetailRequest req)
        {
            return InternalRequestAsync<DescribeComplianceDetailResponse>(req, "DescribeComplianceDetail");
        }

        /// <summary>
        /// 合规管理检查项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceDetailRequest"/></param>
        /// <returns><see cref="DescribeComplianceDetailResponse"/></returns>
        public DescribeComplianceDetailResponse DescribeComplianceDetailSync(DescribeComplianceDetailRequest req)
        {
            return InternalRequestAsync<DescribeComplianceDetailResponse>(req, "DescribeComplianceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合规管理总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceListRequest"/></param>
        /// <returns><see cref="DescribeComplianceListResponse"/></returns>
        public Task<DescribeComplianceListResponse> DescribeComplianceList(DescribeComplianceListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceListResponse>(req, "DescribeComplianceList");
        }

        /// <summary>
        /// 合规管理总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceListRequest"/></param>
        /// <returns><see cref="DescribeComplianceListResponse"/></returns>
        public DescribeComplianceListResponse DescribeComplianceListSync(DescribeComplianceListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceListResponse>(req, "DescribeComplianceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云配置检查项总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigListRequest"/></param>
        /// <returns><see cref="DescribeConfigListResponse"/></returns>
        public Task<DescribeConfigListResponse> DescribeConfigList(DescribeConfigListRequest req)
        {
            return InternalRequestAsync<DescribeConfigListResponse>(req, "DescribeConfigList");
        }

        /// <summary>
        /// 云配置检查项总览页检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigListRequest"/></param>
        /// <returns><see cref="DescribeConfigListResponse"/></returns>
        public DescribeConfigListResponse DescribeConfigListSync(DescribeConfigListRequest req)
        {
            return InternalRequestAsync<DescribeConfigListResponse>(req, "DescribeConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 域名列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainListRequest"/></param>
        /// <returns><see cref="DescribeDomainListResponse"/></returns>
        public Task<DescribeDomainListResponse> DescribeDomainList(DescribeDomainListRequest req)
        {
            return InternalRequestAsync<DescribeDomainListResponse>(req, "DescribeDomainList");
        }

        /// <summary>
        /// 域名列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainListRequest"/></param>
        /// <returns><see cref="DescribeDomainListResponse"/></returns>
        public DescribeDomainListResponse DescribeDomainListSync(DescribeDomainListRequest req)
        {
            return InternalRequestAsync<DescribeDomainListResponse>(req, "DescribeDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEventDetailResponse"/></returns>
        public Task<DescribeEventDetailResponse> DescribeEventDetail(DescribeEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeEventDetailResponse>(req, "DescribeEventDetail");
        }

        /// <summary>
        /// 获取安全事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEventDetailResponse"/></returns>
        public DescribeEventDetailResponse DescribeEventDetailSync(DescribeEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeEventDetailResponse>(req, "DescribeEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取泄露列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakDetectionListRequest"/></param>
        /// <returns><see cref="DescribeLeakDetectionListResponse"/></returns>
        public Task<DescribeLeakDetectionListResponse> DescribeLeakDetectionList(DescribeLeakDetectionListRequest req)
        {
            return InternalRequestAsync<DescribeLeakDetectionListResponse>(req, "DescribeLeakDetectionList");
        }

        /// <summary>
        /// 获取泄露列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLeakDetectionListRequest"/></param>
        /// <returns><see cref="DescribeLeakDetectionListResponse"/></returns>
        public DescribeLeakDetectionListResponse DescribeLeakDetectionListSync(DescribeLeakDetectionListRequest req)
        {
            return InternalRequestAsync<DescribeLeakDetectionListResponse>(req, "DescribeLeakDetectionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取测绘列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMappingResultsRequest"/></param>
        /// <returns><see cref="DescribeMappingResultsResponse"/></returns>
        public Task<DescribeMappingResultsResponse> DescribeMappingResults(DescribeMappingResultsRequest req)
        {
            return InternalRequestAsync<DescribeMappingResultsResponse>(req, "DescribeMappingResults");
        }

        /// <summary>
        /// 获取测绘列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMappingResultsRequest"/></param>
        /// <returns><see cref="DescribeMappingResultsResponse"/></returns>
        public DescribeMappingResultsResponse DescribeMappingResultsSync(DescribeMappingResultsRequest req)
        {
            return InternalRequestAsync<DescribeMappingResultsResponse>(req, "DescribeMappingResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回告警详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSocAlertDetailsRequest"/></param>
        /// <returns><see cref="DescribeSocAlertDetailsResponse"/></returns>
        public Task<DescribeSocAlertDetailsResponse> DescribeSocAlertDetails(DescribeSocAlertDetailsRequest req)
        {
            return InternalRequestAsync<DescribeSocAlertDetailsResponse>(req, "DescribeSocAlertDetails");
        }

        /// <summary>
        /// 返回告警详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSocAlertDetailsRequest"/></param>
        /// <returns><see cref="DescribeSocAlertDetailsResponse"/></returns>
        public DescribeSocAlertDetailsResponse DescribeSocAlertDetailsSync(DescribeSocAlertDetailsRequest req)
        {
            return InternalRequestAsync<DescribeSocAlertDetailsResponse>(req, "DescribeSocAlertDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSocAlertListRequest"/></param>
        /// <returns><see cref="DescribeSocAlertListResponse"/></returns>
        public Task<DescribeSocAlertListResponse> DescribeSocAlertList(DescribeSocAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSocAlertListResponse>(req, "DescribeSocAlertList");
        }

        /// <summary>
        /// 拉取告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSocAlertListRequest"/></param>
        /// <returns><see cref="DescribeSocAlertListResponse"/></returns>
        public DescribeSocAlertListResponse DescribeSocAlertListSync(DescribeSocAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSocAlertListResponse>(req, "DescribeSocAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云安全配置检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSocCheckItemListRequest"/></param>
        /// <returns><see cref="DescribeSocCheckItemListResponse"/></returns>
        public Task<DescribeSocCheckItemListResponse> DescribeSocCheckItemList(DescribeSocCheckItemListRequest req)
        {
            return InternalRequestAsync<DescribeSocCheckItemListResponse>(req, "DescribeSocCheckItemList");
        }

        /// <summary>
        /// 云安全配置检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSocCheckItemListRequest"/></param>
        /// <returns><see cref="DescribeSocCheckItemListResponse"/></returns>
        public DescribeSocCheckItemListResponse DescribeSocCheckItemListSync(DescribeSocCheckItemListRequest req)
        {
            return InternalRequestAsync<DescribeSocCheckItemListResponse>(req, "DescribeSocCheckItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云安全配置检查项结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSocCheckResultListRequest"/></param>
        /// <returns><see cref="DescribeSocCheckResultListResponse"/></returns>
        public Task<DescribeSocCheckResultListResponse> DescribeSocCheckResultList(DescribeSocCheckResultListRequest req)
        {
            return InternalRequestAsync<DescribeSocCheckResultListResponse>(req, "DescribeSocCheckResultList");
        }

        /// <summary>
        /// 云安全配置检查项结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSocCheckResultListRequest"/></param>
        /// <returns><see cref="DescribeSocCheckResultListResponse"/></returns>
        public DescribeSocCheckResultListResponse DescribeSocCheckResultListSync(DescribeSocCheckResultListRequest req)
        {
            return InternalRequestAsync<DescribeSocCheckResultListResponse>(req, "DescribeSocCheckResultList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合规详情项
        /// </summary>
        /// <param name="req"><see cref="DescribeSocCspmComplianceRequest"/></param>
        /// <returns><see cref="DescribeSocCspmComplianceResponse"/></returns>
        public Task<DescribeSocCspmComplianceResponse> DescribeSocCspmCompliance(DescribeSocCspmComplianceRequest req)
        {
            return InternalRequestAsync<DescribeSocCspmComplianceResponse>(req, "DescribeSocCspmCompliance");
        }

        /// <summary>
        /// 合规详情项
        /// </summary>
        /// <param name="req"><see cref="DescribeSocCspmComplianceRequest"/></param>
        /// <returns><see cref="DescribeSocCspmComplianceResponse"/></returns>
        public DescribeSocCspmComplianceResponse DescribeSocCspmComplianceSync(DescribeSocCspmComplianceRequest req)
        {
            return InternalRequestAsync<DescribeSocCspmComplianceResponse>(req, "DescribeSocCspmCompliance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 漏洞列表页，获取漏洞详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDetailResponse"/></returns>
        public Task<DescribeVulDetailResponse> DescribeVulDetail(DescribeVulDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDetailResponse>(req, "DescribeVulDetail");
        }

        /// <summary>
        /// 漏洞列表页，获取漏洞详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDetailResponse"/></returns>
        public DescribeVulDetailResponse DescribeVulDetailSync(DescribeVulDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDetailResponse>(req, "DescribeVulDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 漏洞管理页，获取漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public Task<DescribeVulListResponse> DescribeVulList(DescribeVulListRequest req)
        {
            return InternalRequestAsync<DescribeVulListResponse>(req, "DescribeVulList");
        }

        /// <summary>
        /// 漏洞管理页，获取漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public DescribeVulListResponse DescribeVulListSync(DescribeVulListRequest req)
        {
            return InternalRequestAsync<DescribeVulListResponse>(req, "DescribeVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SaDivulgeScanRuleMutate
        /// </summary>
        /// <param name="req"><see cref="SaDivulgeScanRuleMutateRequest"/></param>
        /// <returns><see cref="SaDivulgeScanRuleMutateResponse"/></returns>
        public Task<SaDivulgeScanRuleMutateResponse> SaDivulgeScanRuleMutate(SaDivulgeScanRuleMutateRequest req)
        {
            return InternalRequestAsync<SaDivulgeScanRuleMutateResponse>(req, "SaDivulgeScanRuleMutate");
        }

        /// <summary>
        /// SaDivulgeScanRuleMutate
        /// </summary>
        /// <param name="req"><see cref="SaDivulgeScanRuleMutateRequest"/></param>
        /// <returns><see cref="SaDivulgeScanRuleMutateResponse"/></returns>
        public SaDivulgeScanRuleMutateResponse SaDivulgeScanRuleMutateSync(SaDivulgeScanRuleMutateRequest req)
        {
            return InternalRequestAsync<SaDivulgeScanRuleMutateResponse>(req, "SaDivulgeScanRuleMutate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全事件通用字段
        /// </summary>
        /// <param name="req"><see cref="SaEventPubRequest"/></param>
        /// <returns><see cref="SaEventPubResponse"/></returns>
        public Task<SaEventPubResponse> SaEventPub(SaEventPubRequest req)
        {
            return InternalRequestAsync<SaEventPubResponse>(req, "SaEventPub");
        }

        /// <summary>
        /// 安全事件通用字段
        /// </summary>
        /// <param name="req"><see cref="SaEventPubRequest"/></param>
        /// <returns><see cref="SaEventPubResponse"/></returns>
        public SaEventPubResponse SaEventPubSync(SaEventPubRequest req)
        {
            return InternalRequestAsync<SaEventPubResponse>(req, "SaEventPub")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

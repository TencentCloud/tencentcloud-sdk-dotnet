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

namespace TencentCloud.Domain.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Domain.V20180808.Models;

   public class DomainClient : AbstractClient{

       private const string endpoint = "domain.tencentcloudapi.com";
       private const string version = "2018-08-08";
       private const string sdkVersion = "SDK_NET_3.0.1159";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DomainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DomainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口 ( BatchModifyDomainInfo ) 用于批量域名信息修改 。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyDomainInfoResponse"/></returns>
        public Task<BatchModifyDomainInfoResponse> BatchModifyDomainInfo(BatchModifyDomainInfoRequest req)
        {
            return InternalRequestAsync<BatchModifyDomainInfoResponse>(req, "BatchModifyDomainInfo");
        }

        /// <summary>
        /// 本接口 ( BatchModifyDomainInfo ) 用于批量域名信息修改 。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyDomainInfoResponse"/></returns>
        public BatchModifyDomainInfoResponse BatchModifyDomainInfoSync(BatchModifyDomainInfoRequest req)
        {
            return InternalRequestAsync<BatchModifyDomainInfoResponse>(req, "BatchModifyDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于用户详情页出价请求
        /// </summary>
        /// <param name="req"><see cref="BidDetailPageRequest"/></param>
        /// <returns><see cref="BidDetailPageResponse"/></returns>
        public Task<BidDetailPageResponse> BidDetailPage(BidDetailPageRequest req)
        {
            return InternalRequestAsync<BidDetailPageResponse>(req, "BidDetailPage");
        }

        /// <summary>
        /// 该接口用于用户详情页出价请求
        /// </summary>
        /// <param name="req"><see cref="BidDetailPageRequest"/></param>
        /// <returns><see cref="BidDetailPageResponse"/></returns>
        public BidDetailPageResponse BidDetailPageSync(BidDetailPageRequest req)
        {
            return InternalRequestAsync<BidDetailPageResponse>(req, "BidDetailPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户合作商预释放出价
        /// </summary>
        /// <param name="req"><see cref="BidPreDomainsRequest"/></param>
        /// <returns><see cref="BidPreDomainsResponse"/></returns>
        public Task<BidPreDomainsResponse> BidPreDomains(BidPreDomainsRequest req)
        {
            return InternalRequestAsync<BidPreDomainsResponse>(req, "BidPreDomains");
        }

        /// <summary>
        /// 用户合作商预释放出价
        /// </summary>
        /// <param name="req"><see cref="BidPreDomainsRequest"/></param>
        /// <returns><see cref="BidPreDomainsResponse"/></returns>
        public BidPreDomainsResponse BidPreDomainsSync(BidPreDomainsRequest req)
        {
            return InternalRequestAsync<BidPreDomainsResponse>(req, "BidPreDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于出价界面出价请求
        /// </summary>
        /// <param name="req"><see cref="BiddingPreReleaseRequest"/></param>
        /// <returns><see cref="BiddingPreReleaseResponse"/></returns>
        public Task<BiddingPreReleaseResponse> BiddingPreRelease(BiddingPreReleaseRequest req)
        {
            return InternalRequestAsync<BiddingPreReleaseResponse>(req, "BiddingPreRelease");
        }

        /// <summary>
        /// 用于出价界面出价请求
        /// </summary>
        /// <param name="req"><see cref="BiddingPreReleaseRequest"/></param>
        /// <returns><see cref="BiddingPreReleaseResponse"/></returns>
        public BiddingPreReleaseResponse BiddingPreReleaseSync(BiddingPreReleaseRequest req)
        {
            return InternalRequestAsync<BiddingPreReleaseResponse>(req, "BiddingPreRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( CheckBatchStatus ) 用于查询批量操作日志状态 。
        /// </summary>
        /// <param name="req"><see cref="CheckBatchStatusRequest"/></param>
        /// <returns><see cref="CheckBatchStatusResponse"/></returns>
        public Task<CheckBatchStatusResponse> CheckBatchStatus(CheckBatchStatusRequest req)
        {
            return InternalRequestAsync<CheckBatchStatusResponse>(req, "CheckBatchStatus");
        }

        /// <summary>
        /// 本接口 ( CheckBatchStatus ) 用于查询批量操作日志状态 。
        /// </summary>
        /// <param name="req"><see cref="CheckBatchStatusRequest"/></param>
        /// <returns><see cref="CheckBatchStatusResponse"/></returns>
        public CheckBatchStatusResponse CheckBatchStatusSync(CheckBatchStatusRequest req)
        {
            return InternalRequestAsync<CheckBatchStatusResponse>(req, "CheckBatchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查域名是否可以注册。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public Task<CheckDomainResponse> CheckDomain(CheckDomainRequest req)
        {
            return InternalRequestAsync<CheckDomainResponse>(req, "CheckDomain");
        }

        /// <summary>
        /// 检查域名是否可以注册。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public CheckDomainResponse CheckDomainSync(CheckDomainRequest req)
        {
            return InternalRequestAsync<CheckDomainResponse>(req, "CheckDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="CreateCustomDnsHostRequest"/></param>
        /// <returns><see cref="CreateCustomDnsHostResponse"/></returns>
        public Task<CreateCustomDnsHostResponse> CreateCustomDnsHost(CreateCustomDnsHostRequest req)
        {
            return InternalRequestAsync<CreateCustomDnsHostResponse>(req, "CreateCustomDnsHost");
        }

        /// <summary>
        /// 创建自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="CreateCustomDnsHostRequest"/></param>
        /// <returns><see cref="CreateCustomDnsHostResponse"/></returns>
        public CreateCustomDnsHostResponse CreateCustomDnsHostSync(CreateCustomDnsHostRequest req)
        {
            return InternalRequestAsync<CreateCustomDnsHostResponse>(req, "CreateCustomDnsHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( CreateDomainBatch ) 用于批量域名注册 。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public Task<CreateDomainBatchResponse> CreateDomainBatch(CreateDomainBatchRequest req)
        {
            return InternalRequestAsync<CreateDomainBatchResponse>(req, "CreateDomainBatch");
        }

        /// <summary>
        /// 本接口 ( CreateDomainBatch ) 用于批量域名注册 。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public CreateDomainBatchResponse CreateDomainBatchSync(CreateDomainBatchRequest req)
        {
            return InternalRequestAsync<CreateDomainBatchResponse>(req, "CreateDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建赎回订单。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRedemptionRequest"/></param>
        /// <returns><see cref="CreateDomainRedemptionResponse"/></returns>
        public Task<CreateDomainRedemptionResponse> CreateDomainRedemption(CreateDomainRedemptionRequest req)
        {
            return InternalRequestAsync<CreateDomainRedemptionResponse>(req, "CreateDomainRedemption");
        }

        /// <summary>
        /// 创建赎回订单。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRedemptionRequest"/></param>
        /// <returns><see cref="CreateDomainRedemptionResponse"/></returns>
        public CreateDomainRedemptionResponse CreateDomainRedemptionSync(CreateDomainRedemptionRequest req)
        {
            return InternalRequestAsync<CreateDomainRedemptionResponse>(req, "CreateDomainRedemption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于创建有效的手机、邮箱
        /// </summary>
        /// <param name="req"><see cref="CreatePhoneEmailRequest"/></param>
        /// <returns><see cref="CreatePhoneEmailResponse"/></returns>
        public Task<CreatePhoneEmailResponse> CreatePhoneEmail(CreatePhoneEmailRequest req)
        {
            return InternalRequestAsync<CreatePhoneEmailResponse>(req, "CreatePhoneEmail");
        }

        /// <summary>
        /// 此接口用于创建有效的手机、邮箱
        /// </summary>
        /// <param name="req"><see cref="CreatePhoneEmailRequest"/></param>
        /// <returns><see cref="CreatePhoneEmailResponse"/></returns>
        public CreatePhoneEmailResponse CreatePhoneEmailSync(CreatePhoneEmailRequest req)
        {
            return InternalRequestAsync<CreatePhoneEmailResponse>(req, "CreatePhoneEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( CreateTemplate ) 用于添加域名信息模板 。
        /// </summary>
        /// <param name="req"><see cref="CreateTemplateRequest"/></param>
        /// <returns><see cref="CreateTemplateResponse"/></returns>
        public Task<CreateTemplateResponse> CreateTemplate(CreateTemplateRequest req)
        {
            return InternalRequestAsync<CreateTemplateResponse>(req, "CreateTemplate");
        }

        /// <summary>
        /// 本接口 ( CreateTemplate ) 用于添加域名信息模板 。
        /// </summary>
        /// <param name="req"><see cref="CreateTemplateRequest"/></param>
        /// <returns><see cref="CreateTemplateResponse"/></returns>
        public CreateTemplateResponse CreateTemplateSync(CreateTemplateRequest req)
        {
            return InternalRequestAsync<CreateTemplateResponse>(req, "CreateTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteBiddingRequest"/></param>
        /// <returns><see cref="DeleteBiddingResponse"/></returns>
        public Task<DeleteBiddingResponse> DeleteBidding(DeleteBiddingRequest req)
        {
            return InternalRequestAsync<DeleteBiddingResponse>(req, "DeleteBidding");
        }

        /// <summary>
        /// 删除记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteBiddingRequest"/></param>
        /// <returns><see cref="DeleteBiddingResponse"/></returns>
        public DeleteBiddingResponse DeleteBiddingSync(DeleteBiddingRequest req)
        {
            return InternalRequestAsync<DeleteBiddingResponse>(req, "DeleteBidding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomDnsHostRequest"/></param>
        /// <returns><see cref="DeleteCustomDnsHostResponse"/></returns>
        public Task<DeleteCustomDnsHostResponse> DeleteCustomDnsHost(DeleteCustomDnsHostRequest req)
        {
            return InternalRequestAsync<DeleteCustomDnsHostResponse>(req, "DeleteCustomDnsHost");
        }

        /// <summary>
        /// 删除自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomDnsHostRequest"/></param>
        /// <returns><see cref="DeleteCustomDnsHostResponse"/></returns>
        public DeleteCustomDnsHostResponse DeleteCustomDnsHostSync(DeleteCustomDnsHostRequest req)
        {
            return InternalRequestAsync<DeleteCustomDnsHostResponse>(req, "DeleteCustomDnsHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于删除已验证的手机邮箱
        /// </summary>
        /// <param name="req"><see cref="DeletePhoneEmailRequest"/></param>
        /// <returns><see cref="DeletePhoneEmailResponse"/></returns>
        public Task<DeletePhoneEmailResponse> DeletePhoneEmail(DeletePhoneEmailRequest req)
        {
            return InternalRequestAsync<DeletePhoneEmailResponse>(req, "DeletePhoneEmail");
        }

        /// <summary>
        /// 此接口用于删除已验证的手机邮箱
        /// </summary>
        /// <param name="req"><see cref="DeletePhoneEmailRequest"/></param>
        /// <returns><see cref="DeletePhoneEmailResponse"/></returns>
        public DeletePhoneEmailResponse DeletePhoneEmailSync(DeletePhoneEmailRequest req)
        {
            return InternalRequestAsync<DeletePhoneEmailResponse>(req, "DeletePhoneEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于清除多余的预定域名信息
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedPreDomainInfoRequest"/></param>
        /// <returns><see cref="DeleteReservedPreDomainInfoResponse"/></returns>
        public Task<DeleteReservedPreDomainInfoResponse> DeleteReservedPreDomainInfo(DeleteReservedPreDomainInfoRequest req)
        {
            return InternalRequestAsync<DeleteReservedPreDomainInfoResponse>(req, "DeleteReservedPreDomainInfo");
        }

        /// <summary>
        /// 用于清除多余的预定域名信息
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedPreDomainInfoRequest"/></param>
        /// <returns><see cref="DeleteReservedPreDomainInfoResponse"/></returns>
        public DeleteReservedPreDomainInfoResponse DeleteReservedPreDomainInfoSync(DeleteReservedPreDomainInfoRequest req)
        {
            return InternalRequestAsync<DeleteReservedPreDomainInfoResponse>(req, "DeleteReservedPreDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( DeleteTemplate ) 用于删除信息模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateRequest"/></param>
        /// <returns><see cref="DeleteTemplateResponse"/></returns>
        public Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTemplateResponse>(req, "DeleteTemplate");
        }

        /// <summary>
        /// 本接口 ( DeleteTemplate ) 用于删除信息模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateRequest"/></param>
        /// <returns><see cref="DeleteTemplateResponse"/></returns>
        public DeleteTemplateResponse DeleteTemplateSync(DeleteTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTemplateResponse>(req, "DeleteTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户控制台获取竞价列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuctionListRequest"/></param>
        /// <returns><see cref="DescribeAuctionListResponse"/></returns>
        public Task<DescribeAuctionListResponse> DescribeAuctionList(DescribeAuctionListRequest req)
        {
            return InternalRequestAsync<DescribeAuctionListResponse>(req, "DescribeAuctionList");
        }

        /// <summary>
        /// 用户控制台获取竞价列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuctionListRequest"/></param>
        /// <returns><see cref="DescribeAuctionListResponse"/></returns>
        public DescribeAuctionListResponse DescribeAuctionListSync(DescribeAuctionListRequest req)
        {
            return InternalRequestAsync<DescribeAuctionListResponse>(req, "DescribeAuctionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogDetails ) 用于获取批量操作日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogDetailsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogDetailsResponse"/></returns>
        public Task<DescribeBatchOperationLogDetailsResponse> DescribeBatchOperationLogDetails(DescribeBatchOperationLogDetailsRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperationLogDetailsResponse>(req, "DescribeBatchOperationLogDetails");
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogDetails ) 用于获取批量操作日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogDetailsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogDetailsResponse"/></returns>
        public DescribeBatchOperationLogDetailsResponse DescribeBatchOperationLogDetailsSync(DescribeBatchOperationLogDetailsRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperationLogDetailsResponse>(req, "DescribeBatchOperationLogDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogs ) 用于获取批量操作日志 。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogsResponse"/></returns>
        public Task<DescribeBatchOperationLogsResponse> DescribeBatchOperationLogs(DescribeBatchOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperationLogsResponse>(req, "DescribeBatchOperationLogs");
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogs ) 用于获取批量操作日志 。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogsResponse"/></returns>
        public DescribeBatchOperationLogsResponse DescribeBatchOperationLogsSync(DescribeBatchOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeBatchOperationLogsResponse>(req, "DescribeBatchOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 我预约的域名-预约详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingAppointDetailRequest"/></param>
        /// <returns><see cref="DescribeBiddingAppointDetailResponse"/></returns>
        public Task<DescribeBiddingAppointDetailResponse> DescribeBiddingAppointDetail(DescribeBiddingAppointDetailRequest req)
        {
            return InternalRequestAsync<DescribeBiddingAppointDetailResponse>(req, "DescribeBiddingAppointDetail");
        }

        /// <summary>
        /// 我预约的域名-预约详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingAppointDetailRequest"/></param>
        /// <returns><see cref="DescribeBiddingAppointDetailResponse"/></returns>
        public DescribeBiddingAppointDetailResponse DescribeBiddingAppointDetailSync(DescribeBiddingAppointDetailRequest req)
        {
            return InternalRequestAsync<DescribeBiddingAppointDetailResponse>(req, "DescribeBiddingAppointDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 我预定的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingAppointListRequest"/></param>
        /// <returns><see cref="DescribeBiddingAppointListResponse"/></returns>
        public Task<DescribeBiddingAppointListResponse> DescribeBiddingAppointList(DescribeBiddingAppointListRequest req)
        {
            return InternalRequestAsync<DescribeBiddingAppointListResponse>(req, "DescribeBiddingAppointList");
        }

        /// <summary>
        /// 我预定的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingAppointListRequest"/></param>
        /// <returns><see cref="DescribeBiddingAppointListResponse"/></returns>
        public DescribeBiddingAppointListResponse DescribeBiddingAppointListSync(DescribeBiddingAppointListRequest req)
        {
            return InternalRequestAsync<DescribeBiddingAppointListResponse>(req, "DescribeBiddingAppointList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 我竞价的域名-竞价详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingDetailRequest"/></param>
        /// <returns><see cref="DescribeBiddingDetailResponse"/></returns>
        public Task<DescribeBiddingDetailResponse> DescribeBiddingDetail(DescribeBiddingDetailRequest req)
        {
            return InternalRequestAsync<DescribeBiddingDetailResponse>(req, "DescribeBiddingDetail");
        }

        /// <summary>
        /// 我竞价的域名-竞价详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingDetailRequest"/></param>
        /// <returns><see cref="DescribeBiddingDetailResponse"/></returns>
        public DescribeBiddingDetailResponse DescribeBiddingDetailSync(DescribeBiddingDetailRequest req)
        {
            return InternalRequestAsync<DescribeBiddingDetailResponse>(req, "DescribeBiddingDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 我竞价的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingListRequest"/></param>
        /// <returns><see cref="DescribeBiddingListResponse"/></returns>
        public Task<DescribeBiddingListResponse> DescribeBiddingList(DescribeBiddingListRequest req)
        {
            return InternalRequestAsync<DescribeBiddingListResponse>(req, "DescribeBiddingList");
        }

        /// <summary>
        /// 我竞价的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingListRequest"/></param>
        /// <returns><see cref="DescribeBiddingListResponse"/></returns>
        public DescribeBiddingListResponse DescribeBiddingListSync(DescribeBiddingListRequest req)
        {
            return InternalRequestAsync<DescribeBiddingListResponse>(req, "DescribeBiddingList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 我得标的域名-得标详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingSuccessfulDetailRequest"/></param>
        /// <returns><see cref="DescribeBiddingSuccessfulDetailResponse"/></returns>
        public Task<DescribeBiddingSuccessfulDetailResponse> DescribeBiddingSuccessfulDetail(DescribeBiddingSuccessfulDetailRequest req)
        {
            return InternalRequestAsync<DescribeBiddingSuccessfulDetailResponse>(req, "DescribeBiddingSuccessfulDetail");
        }

        /// <summary>
        /// 我得标的域名-得标详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingSuccessfulDetailRequest"/></param>
        /// <returns><see cref="DescribeBiddingSuccessfulDetailResponse"/></returns>
        public DescribeBiddingSuccessfulDetailResponse DescribeBiddingSuccessfulDetailSync(DescribeBiddingSuccessfulDetailRequest req)
        {
            return InternalRequestAsync<DescribeBiddingSuccessfulDetailResponse>(req, "DescribeBiddingSuccessfulDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 我得标的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingSuccessfulListRequest"/></param>
        /// <returns><see cref="DescribeBiddingSuccessfulListResponse"/></returns>
        public Task<DescribeBiddingSuccessfulListResponse> DescribeBiddingSuccessfulList(DescribeBiddingSuccessfulListRequest req)
        {
            return InternalRequestAsync<DescribeBiddingSuccessfulListResponse>(req, "DescribeBiddingSuccessfulList");
        }

        /// <summary>
        /// 我得标的域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeBiddingSuccessfulListRequest"/></param>
        /// <returns><see cref="DescribeBiddingSuccessfulListResponse"/></returns>
        public DescribeBiddingSuccessfulListResponse DescribeBiddingSuccessfulListSync(DescribeBiddingSuccessfulListRequest req)
        {
            return InternalRequestAsync<DescribeBiddingSuccessfulListResponse>(req, "DescribeBiddingSuccessfulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomDnsHostSetRequest"/></param>
        /// <returns><see cref="DescribeCustomDnsHostSetResponse"/></returns>
        public Task<DescribeCustomDnsHostSetResponse> DescribeCustomDnsHostSet(DescribeCustomDnsHostSetRequest req)
        {
            return InternalRequestAsync<DescribeCustomDnsHostSetResponse>(req, "DescribeCustomDnsHostSet");
        }

        /// <summary>
        /// 查询自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomDnsHostSetRequest"/></param>
        /// <returns><see cref="DescribeCustomDnsHostSetResponse"/></returns>
        public DescribeCustomDnsHostSetResponse DescribeCustomDnsHostSetSync(DescribeCustomDnsHostSetRequest req)
        {
            return InternalRequestAsync<DescribeCustomDnsHostSetResponse>(req, "DescribeCustomDnsHostSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (  DescribeDomainBaseInfo) 获取域名基本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainBaseInfoResponse"/></returns>
        public Task<DescribeDomainBaseInfoResponse> DescribeDomainBaseInfo(DescribeDomainBaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainBaseInfoResponse>(req, "DescribeDomainBaseInfo");
        }

        /// <summary>
        /// 本接口 (  DescribeDomainBaseInfo) 获取域名基本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainBaseInfoResponse"/></returns>
        public DescribeDomainBaseInfoResponse DescribeDomainBaseInfoSync(DescribeDomainBaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainBaseInfoResponse>(req, "DescribeDomainBaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (  DescribeDomainNameList ) 我的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainNameListRequest"/></param>
        /// <returns><see cref="DescribeDomainNameListResponse"/></returns>
        public Task<DescribeDomainNameListResponse> DescribeDomainNameList(DescribeDomainNameListRequest req)
        {
            return InternalRequestAsync<DescribeDomainNameListResponse>(req, "DescribeDomainNameList");
        }

        /// <summary>
        /// 本接口 (  DescribeDomainNameList ) 我的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainNameListRequest"/></param>
        /// <returns><see cref="DescribeDomainNameListResponse"/></returns>
        public DescribeDomainNameListResponse DescribeDomainNameListSync(DescribeDomainNameListRequest req)
        {
            return InternalRequestAsync<DescribeDomainNameListResponse>(req, "DescribeDomainNameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns><see cref="DescribeDomainPriceListResponse"/></returns>
        public Task<DescribeDomainPriceListResponse> DescribeDomainPriceList(DescribeDomainPriceListRequest req)
        {
            return InternalRequestAsync<DescribeDomainPriceListResponse>(req, "DescribeDomainPriceList");
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns><see cref="DescribeDomainPriceListResponse"/></returns>
        public DescribeDomainPriceListResponse DescribeDomainPriceListSync(DescribeDomainPriceListRequest req)
        {
            return InternalRequestAsync<DescribeDomainPriceListResponse>(req, "DescribeDomainPriceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取域名实名信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainSimpleInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainSimpleInfoResponse"/></returns>
        public Task<DescribeDomainSimpleInfoResponse> DescribeDomainSimpleInfo(DescribeDomainSimpleInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainSimpleInfoResponse>(req, "DescribeDomainSimpleInfo");
        }

        /// <summary>
        /// 获取域名实名信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainSimpleInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainSimpleInfoResponse"/></returns>
        public DescribeDomainSimpleInfoResponse DescribeDomainSimpleInfoSync(DescribeDomainSimpleInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainSimpleInfoResponse>(req, "DescribeDomainSimpleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 等待支付详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribePayWaitDetailRequest"/></param>
        /// <returns><see cref="DescribePayWaitDetailResponse"/></returns>
        public Task<DescribePayWaitDetailResponse> DescribePayWaitDetail(DescribePayWaitDetailRequest req)
        {
            return InternalRequestAsync<DescribePayWaitDetailResponse>(req, "DescribePayWaitDetail");
        }

        /// <summary>
        /// 等待支付详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribePayWaitDetailRequest"/></param>
        /// <returns><see cref="DescribePayWaitDetailResponse"/></returns>
        public DescribePayWaitDetailResponse DescribePayWaitDetailSync(DescribePayWaitDetailRequest req)
        {
            return InternalRequestAsync<DescribePayWaitDetailResponse>(req, "DescribePayWaitDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取已验证的手机邮箱列表
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribePhoneEmailListResponse"/></returns>
        public Task<DescribePhoneEmailListResponse> DescribePhoneEmailList(DescribePhoneEmailListRequest req)
        {
            return InternalRequestAsync<DescribePhoneEmailListResponse>(req, "DescribePhoneEmailList");
        }

        /// <summary>
        /// 本接口用于获取已验证的手机邮箱列表
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribePhoneEmailListResponse"/></returns>
        public DescribePhoneEmailListResponse DescribePhoneEmailListSync(DescribePhoneEmailListRequest req)
        {
            return InternalRequestAsync<DescribePhoneEmailListResponse>(req, "DescribePhoneEmailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于预释放竞价列表数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribePreAuctionListRequest"/></param>
        /// <returns><see cref="DescribePreAuctionListResponse"/></returns>
        public Task<DescribePreAuctionListResponse> DescribePreAuctionList(DescribePreAuctionListRequest req)
        {
            return InternalRequestAsync<DescribePreAuctionListResponse>(req, "DescribePreAuctionList");
        }

        /// <summary>
        /// 用于预释放竞价列表数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribePreAuctionListRequest"/></param>
        /// <returns><see cref="DescribePreAuctionListResponse"/></returns>
        public DescribePreAuctionListResponse DescribePreAuctionListSync(DescribePreAuctionListRequest req)
        {
            return InternalRequestAsync<DescribePreAuctionListResponse>(req, "DescribePreAuctionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户服务商提前获取预释放域名数据，查询数据根据结束时间进行倒序。
        /// </summary>
        /// <param name="req"><see cref="DescribePreDomainListRequest"/></param>
        /// <returns><see cref="DescribePreDomainListResponse"/></returns>
        public Task<DescribePreDomainListResponse> DescribePreDomainList(DescribePreDomainListRequest req)
        {
            return InternalRequestAsync<DescribePreDomainListResponse>(req, "DescribePreDomainList");
        }

        /// <summary>
        /// 用户服务商提前获取预释放域名数据，查询数据根据结束时间进行倒序。
        /// </summary>
        /// <param name="req"><see cref="DescribePreDomainListRequest"/></param>
        /// <returns><see cref="DescribePreDomainListResponse"/></returns>
        public DescribePreDomainListResponse DescribePreDomainListSync(DescribePreDomainListRequest req)
        {
            return InternalRequestAsync<DescribePreDomainListResponse>(req, "DescribePreDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于预释放页面查询
        /// </summary>
        /// <param name="req"><see cref="DescribePreReleaseListRequest"/></param>
        /// <returns><see cref="DescribePreReleaseListResponse"/></returns>
        public Task<DescribePreReleaseListResponse> DescribePreReleaseList(DescribePreReleaseListRequest req)
        {
            return InternalRequestAsync<DescribePreReleaseListResponse>(req, "DescribePreReleaseList");
        }

        /// <summary>
        /// 接口用于预释放页面查询
        /// </summary>
        /// <param name="req"><see cref="DescribePreReleaseListRequest"/></param>
        /// <returns><see cref="DescribePreReleaseListResponse"/></returns>
        public DescribePreReleaseListResponse DescribePreReleaseListSync(DescribePreReleaseListRequest req)
        {
            return InternalRequestAsync<DescribePreReleaseListResponse>(req, "DescribePreReleaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于获取合作商竞价过程中竞价详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedBidInfoRequest"/></param>
        /// <returns><see cref="DescribeReservedBidInfoResponse"/></returns>
        public Task<DescribeReservedBidInfoResponse> DescribeReservedBidInfo(DescribeReservedBidInfoRequest req)
        {
            return InternalRequestAsync<DescribeReservedBidInfoResponse>(req, "DescribeReservedBidInfo");
        }

        /// <summary>
        /// 接口用于获取合作商竞价过程中竞价详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedBidInfoRequest"/></param>
        /// <returns><see cref="DescribeReservedBidInfoResponse"/></returns>
        public DescribeReservedBidInfoResponse DescribeReservedBidInfoSync(DescribeReservedBidInfoRequest req)
        {
            return InternalRequestAsync<DescribeReservedBidInfoResponse>(req, "DescribeReservedBidInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合作商用于查询预约预释放状态信息内容
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedPreDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeReservedPreDomainInfoResponse"/></returns>
        public Task<DescribeReservedPreDomainInfoResponse> DescribeReservedPreDomainInfo(DescribeReservedPreDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeReservedPreDomainInfoResponse>(req, "DescribeReservedPreDomainInfo");
        }

        /// <summary>
        /// 合作商用于查询预约预释放状态信息内容
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedPreDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeReservedPreDomainInfoResponse"/></returns>
        public DescribeReservedPreDomainInfoResponse DescribeReservedPreDomainInfoSync(DescribeReservedPreDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeReservedPreDomainInfoResponse>(req, "DescribeReservedPreDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeTemplate) 用于获取模板信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public Task<DescribeTemplateResponse> DescribeTemplate(DescribeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeTemplateResponse>(req, "DescribeTemplate");
        }

        /// <summary>
        /// 本接口 (DescribeTemplate) 用于获取模板信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public DescribeTemplateResponse DescribeTemplateSync(DescribeTemplateRequest req)
        {
            return InternalRequestAsync<DescribeTemplateResponse>(req, "DescribeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeTemplateList) 用于获取信息模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeTemplateListResponse>(req, "DescribeTemplateList");
        }

        /// <summary>
        /// 本接口 (DescribeTemplateList) 用于获取信息模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public DescribeTemplateListResponse DescribeTemplateListSync(DescribeTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeTemplateListResponse>(req, "DescribeTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取域名注册当前支持注册的后缀
        /// </summary>
        /// <param name="req"><see cref="DescribeTldListRequest"/></param>
        /// <returns><see cref="DescribeTldListResponse"/></returns>
        public Task<DescribeTldListResponse> DescribeTldList(DescribeTldListRequest req)
        {
            return InternalRequestAsync<DescribeTldListResponse>(req, "DescribeTldList");
        }

        /// <summary>
        /// 用于获取域名注册当前支持注册的后缀
        /// </summary>
        /// <param name="req"><see cref="DescribeTldListRequest"/></param>
        /// <returns><see cref="DescribeTldListResponse"/></returns>
        public DescribeTldListResponse DescribeTldListSync(DescribeTldListRequest req)
        {
            return InternalRequestAsync<DescribeTldListResponse>(req, "DescribeTldList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询预释放未预约域名详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnPreDomainDetailRequest"/></param>
        /// <returns><see cref="DescribeUnPreDomainDetailResponse"/></returns>
        public Task<DescribeUnPreDomainDetailResponse> DescribeUnPreDomainDetail(DescribeUnPreDomainDetailRequest req)
        {
            return InternalRequestAsync<DescribeUnPreDomainDetailResponse>(req, "DescribeUnPreDomainDetail");
        }

        /// <summary>
        /// 查询预释放未预约域名详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnPreDomainDetailRequest"/></param>
        /// <returns><see cref="DescribeUnPreDomainDetailResponse"/></returns>
        public DescribeUnPreDomainDetailResponse DescribeUnPreDomainDetailSync(DescribeUnPreDomainDetailRequest req)
        {
            return InternalRequestAsync<DescribeUnPreDomainDetailResponse>(req, "DescribeUnPreDomainDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomDnsHostRequest"/></param>
        /// <returns><see cref="ModifyCustomDnsHostResponse"/></returns>
        public Task<ModifyCustomDnsHostResponse> ModifyCustomDnsHost(ModifyCustomDnsHostRequest req)
        {
            return InternalRequestAsync<ModifyCustomDnsHostResponse>(req, "ModifyCustomDnsHost");
        }

        /// <summary>
        /// 修改自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomDnsHostRequest"/></param>
        /// <returns><see cref="ModifyCustomDnsHostResponse"/></returns>
        public ModifyCustomDnsHostResponse ModifyCustomDnsHostSync(ModifyCustomDnsHostRequest req)
        {
            return InternalRequestAsync<ModifyCustomDnsHostResponse>(req, "ModifyCustomDnsHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( ModifyDomainDNSBatch) 用于批量域名 DNS 修改 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainDNSBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainDNSBatchResponse"/></returns>
        public Task<ModifyDomainDNSBatchResponse> ModifyDomainDNSBatch(ModifyDomainDNSBatchRequest req)
        {
            return InternalRequestAsync<ModifyDomainDNSBatchResponse>(req, "ModifyDomainDNSBatch");
        }

        /// <summary>
        /// 本接口 ( ModifyDomainDNSBatch) 用于批量域名 DNS 修改 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainDNSBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainDNSBatchResponse"/></returns>
        public ModifyDomainDNSBatchResponse ModifyDomainDNSBatchSync(ModifyDomainDNSBatchRequest req)
        {
            return InternalRequestAsync<ModifyDomainDNSBatchResponse>(req, "ModifyDomainDNSBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( ModifyDomainOwnerBatch) 用于域名批量账号间转移 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerBatchResponse"/></returns>
        public Task<ModifyDomainOwnerBatchResponse> ModifyDomainOwnerBatch(ModifyDomainOwnerBatchRequest req)
        {
            return InternalRequestAsync<ModifyDomainOwnerBatchResponse>(req, "ModifyDomainOwnerBatch");
        }

        /// <summary>
        /// 本接口 ( ModifyDomainOwnerBatch) 用于域名批量账号间转移 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerBatchResponse"/></returns>
        public ModifyDomainOwnerBatchResponse ModifyDomainOwnerBatchSync(ModifyDomainOwnerBatchRequest req)
        {
            return InternalRequestAsync<ModifyDomainOwnerBatchResponse>(req, "ModifyDomainOwnerBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 国际站-修改DNS Host
        /// </summary>
        /// <param name="req"><see cref="ModifyIntlCustomDnsHostRequest"/></param>
        /// <returns><see cref="ModifyIntlCustomDnsHostResponse"/></returns>
        public Task<ModifyIntlCustomDnsHostResponse> ModifyIntlCustomDnsHost(ModifyIntlCustomDnsHostRequest req)
        {
            return InternalRequestAsync<ModifyIntlCustomDnsHostResponse>(req, "ModifyIntlCustomDnsHost");
        }

        /// <summary>
        /// 国际站-修改DNS Host
        /// </summary>
        /// <param name="req"><see cref="ModifyIntlCustomDnsHostRequest"/></param>
        /// <returns><see cref="ModifyIntlCustomDnsHostResponse"/></returns>
        public ModifyIntlCustomDnsHostResponse ModifyIntlCustomDnsHostSync(ModifyIntlCustomDnsHostRequest req)
        {
            return InternalRequestAsync<ModifyIntlCustomDnsHostResponse>(req, "ModifyIntlCustomDnsHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模板信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTemplateRequest"/></param>
        /// <returns><see cref="ModifyTemplateResponse"/></returns>
        public Task<ModifyTemplateResponse> ModifyTemplate(ModifyTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTemplateResponse>(req, "ModifyTemplate");
        }

        /// <summary>
        /// 修改模板信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTemplateRequest"/></param>
        /// <returns><see cref="ModifyTemplateResponse"/></returns>
        public ModifyTemplateResponse ModifyTemplateSync(ModifyTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTemplateResponse>(req, "ModifyTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( RenewDomainBatch ) 用于批量续费域名 。
        /// </summary>
        /// <param name="req"><see cref="RenewDomainBatchRequest"/></param>
        /// <returns><see cref="RenewDomainBatchResponse"/></returns>
        public Task<RenewDomainBatchResponse> RenewDomainBatch(RenewDomainBatchRequest req)
        {
            return InternalRequestAsync<RenewDomainBatchResponse>(req, "RenewDomainBatch");
        }

        /// <summary>
        /// 本接口 ( RenewDomainBatch ) 用于批量续费域名 。
        /// </summary>
        /// <param name="req"><see cref="RenewDomainBatchRequest"/></param>
        /// <returns><see cref="RenewDomainBatchResponse"/></returns>
        public RenewDomainBatchResponse RenewDomainBatchSync(RenewDomainBatchRequest req)
        {
            return InternalRequestAsync<RenewDomainBatchResponse>(req, "RenewDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于合作商对预释放域名进行预留。
        /// </summary>
        /// <param name="req"><see cref="ReservedPreDomainsRequest"/></param>
        /// <returns><see cref="ReservedPreDomainsResponse"/></returns>
        public Task<ReservedPreDomainsResponse> ReservedPreDomains(ReservedPreDomainsRequest req)
        {
            return InternalRequestAsync<ReservedPreDomainsResponse>(req, "ReservedPreDomains");
        }

        /// <summary>
        /// 用于合作商对预释放域名进行预留。
        /// </summary>
        /// <param name="req"><see cref="ReservedPreDomainsRequest"/></param>
        /// <returns><see cref="ReservedPreDomainsResponse"/></returns>
        public ReservedPreDomainsResponse ReservedPreDomainsSync(ReservedPreDomainsRequest req)
        {
            return InternalRequestAsync<ReservedPreDomainsResponse>(req, "ReservedPreDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于发送手机邮箱验证码。
        /// </summary>
        /// <param name="req"><see cref="SendPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendPhoneEmailCodeResponse"/></returns>
        public Task<SendPhoneEmailCodeResponse> SendPhoneEmailCode(SendPhoneEmailCodeRequest req)
        {
            return InternalRequestAsync<SendPhoneEmailCodeResponse>(req, "SendPhoneEmailCode");
        }

        /// <summary>
        /// 此接口用于发送手机邮箱验证码。
        /// </summary>
        /// <param name="req"><see cref="SendPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendPhoneEmailCodeResponse"/></returns>
        public SendPhoneEmailCodeResponse SendPhoneEmailCodeSync(SendPhoneEmailCodeRequest req)
        {
            return InternalRequestAsync<SendPhoneEmailCodeResponse>(req, "SendPhoneEmailCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( SetDomainAutoRenew ) 用于设置域名自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetDomainAutoRenewResponse"/></returns>
        public Task<SetDomainAutoRenewResponse> SetDomainAutoRenew(SetDomainAutoRenewRequest req)
        {
            return InternalRequestAsync<SetDomainAutoRenewResponse>(req, "SetDomainAutoRenew");
        }

        /// <summary>
        /// 本接口 ( SetDomainAutoRenew ) 用于设置域名自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetDomainAutoRenewResponse"/></returns>
        public SetDomainAutoRenewResponse SetDomainAutoRenewSync(SetDomainAutoRenewRequest req)
        {
            return InternalRequestAsync<SetDomainAutoRenewResponse>(req, "SetDomainAutoRenew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="SyncCustomDnsHostRequest"/></param>
        /// <returns><see cref="SyncCustomDnsHostResponse"/></returns>
        public Task<SyncCustomDnsHostResponse> SyncCustomDnsHost(SyncCustomDnsHostRequest req)
        {
            return InternalRequestAsync<SyncCustomDnsHostResponse>(req, "SyncCustomDnsHost");
        }

        /// <summary>
        /// 同步自定义DNS Host
        /// </summary>
        /// <param name="req"><see cref="SyncCustomDnsHostRequest"/></param>
        /// <returns><see cref="SyncCustomDnsHostResponse"/></returns>
        public SyncCustomDnsHostResponse SyncCustomDnsHostSync(SyncCustomDnsHostRequest req)
        {
            return InternalRequestAsync<SyncCustomDnsHostResponse>(req, "SyncCustomDnsHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量转入域名 。
        /// </summary>
        /// <param name="req"><see cref="TransferInDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInDomainBatchResponse"/></returns>
        public Task<TransferInDomainBatchResponse> TransferInDomainBatch(TransferInDomainBatchRequest req)
        {
            return InternalRequestAsync<TransferInDomainBatchResponse>(req, "TransferInDomainBatch");
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量转入域名 。
        /// </summary>
        /// <param name="req"><see cref="TransferInDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInDomainBatchResponse"/></returns>
        public TransferInDomainBatchResponse TransferInDomainBatchSync(TransferInDomainBatchRequest req)
        {
            return InternalRequestAsync<TransferInDomainBatchResponse>(req, "TransferInDomainBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( TransferProhibitionBatch ) 用于批量禁止域名转移 。
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionBatchResponse"/></returns>
        public Task<TransferProhibitionBatchResponse> TransferProhibitionBatch(TransferProhibitionBatchRequest req)
        {
            return InternalRequestAsync<TransferProhibitionBatchResponse>(req, "TransferProhibitionBatch");
        }

        /// <summary>
        /// 本接口 ( TransferProhibitionBatch ) 用于批量禁止域名转移 。
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionBatchResponse"/></returns>
        public TransferProhibitionBatchResponse TransferProhibitionBatchSync(TransferProhibitionBatchRequest req)
        {
            return InternalRequestAsync<TransferProhibitionBatchResponse>(req, "TransferProhibitionBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( UpdateProhibitionBatch ) 用于批量禁止更新锁。
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionBatchResponse"/></returns>
        public Task<UpdateProhibitionBatchResponse> UpdateProhibitionBatch(UpdateProhibitionBatchRequest req)
        {
            return InternalRequestAsync<UpdateProhibitionBatchResponse>(req, "UpdateProhibitionBatch");
        }

        /// <summary>
        /// 本接口 ( UpdateProhibitionBatch ) 用于批量禁止更新锁。
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionBatchResponse"/></returns>
        public UpdateProhibitionBatchResponse UpdateProhibitionBatchSync(UpdateProhibitionBatchRequest req)
        {
            return InternalRequestAsync<UpdateProhibitionBatchResponse>(req, "UpdateProhibitionBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 ( UploadImage ) 用于证件图片上传 。
        /// </summary>
        /// <param name="req"><see cref="UploadImageRequest"/></param>
        /// <returns><see cref="UploadImageResponse"/></returns>
        public Task<UploadImageResponse> UploadImage(UploadImageRequest req)
        {
            return InternalRequestAsync<UploadImageResponse>(req, "UploadImage");
        }

        /// <summary>
        /// 本接口 ( UploadImage ) 用于证件图片上传 。
        /// </summary>
        /// <param name="req"><see cref="UploadImageRequest"/></param>
        /// <returns><see cref="UploadImageResponse"/></returns>
        public UploadImageResponse UploadImageSync(UploadImageRequest req)
        {
            return InternalRequestAsync<UploadImageResponse>(req, "UploadImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

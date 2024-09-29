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

namespace TencentCloud.Wav.V20210129
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wav.V20210129.Models;

   public class WavClient : AbstractClient{

       private const string endpoint = "wav.tencentcloudapi.com";
       private const string version = "2021-01-29";
       private const string sdkVersion = "SDK_NET_3.0.1099";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WavClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WavClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 新增渠道活码接口
        /// </summary>
        /// <param name="req"><see cref="CreateChannelCodeRequest"/></param>
        /// <returns><see cref="CreateChannelCodeResponse"/></returns>
        public Task<CreateChannelCodeResponse> CreateChannelCode(CreateChannelCodeRequest req)
        {
            return InternalRequestAsync<CreateChannelCodeResponse>(req, "CreateChannelCode");
        }

        /// <summary>
        /// 新增渠道活码接口
        /// </summary>
        /// <param name="req"><see cref="CreateChannelCodeRequest"/></param>
        /// <returns><see cref="CreateChannelCodeResponse"/></returns>
        public CreateChannelCodeResponse CreateChannelCodeSync(CreateChannelCodeRequest req)
        {
            return InternalRequestAsync<CreateChannelCodeResponse>(req, "CreateChannelCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用户设置标签库, 每个企业最多可配置3000个企业标签。
        /// </summary>
        /// <param name="req"><see cref="CreateCorpTagRequest"/></param>
        /// <returns><see cref="CreateCorpTagResponse"/></returns>
        public Task<CreateCorpTagResponse> CreateCorpTag(CreateCorpTagRequest req)
        {
            return InternalRequestAsync<CreateCorpTagResponse>(req, "CreateCorpTag");
        }

        /// <summary>
        /// 该接口用户设置标签库, 每个企业最多可配置3000个企业标签。
        /// </summary>
        /// <param name="req"><see cref="CreateCorpTagRequest"/></param>
        /// <returns><see cref="CreateCorpTagResponse"/></returns>
        public CreateCorpTagResponse CreateCorpTagSync(CreateCorpTagRequest req)
        {
            return InternalRequestAsync<CreateCorpTagResponse>(req, "CreateCorpTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 线索回收接口
        /// </summary>
        /// <param name="req"><see cref="CreateLeadRequest"/></param>
        /// <returns><see cref="CreateLeadResponse"/></returns>
        public Task<CreateLeadResponse> CreateLead(CreateLeadRequest req)
        {
            return InternalRequestAsync<CreateLeadResponse>(req, "CreateLead");
        }

        /// <summary>
        /// 线索回收接口
        /// </summary>
        /// <param name="req"><see cref="CreateLeadRequest"/></param>
        /// <returns><see cref="CreateLeadResponse"/></returns>
        public CreateLeadResponse CreateLeadSync(CreateLeadRequest req)
        {
            return InternalRequestAsync<CreateLeadResponse>(req, "CreateLead")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据游标拉取活动参与列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityJoinListRequest"/></param>
        /// <returns><see cref="QueryActivityJoinListResponse"/></returns>
        public Task<QueryActivityJoinListResponse> QueryActivityJoinList(QueryActivityJoinListRequest req)
        {
            return InternalRequestAsync<QueryActivityJoinListResponse>(req, "QueryActivityJoinList");
        }

        /// <summary>
        /// 根据游标拉取活动参与列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityJoinListRequest"/></param>
        /// <returns><see cref="QueryActivityJoinListResponse"/></returns>
        public QueryActivityJoinListResponse QueryActivityJoinListSync(QueryActivityJoinListRequest req)
        {
            return InternalRequestAsync<QueryActivityJoinListResponse>(req, "QueryActivityJoinList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据游标拉取活动列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityListRequest"/></param>
        /// <returns><see cref="QueryActivityListResponse"/></returns>
        public Task<QueryActivityListResponse> QueryActivityList(QueryActivityListRequest req)
        {
            return InternalRequestAsync<QueryActivityListResponse>(req, "QueryActivityList");
        }

        /// <summary>
        /// 根据游标拉取活动列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityListRequest"/></param>
        /// <returns><see cref="QueryActivityListResponse"/></returns>
        public QueryActivityListResponse QueryActivityListSync(QueryActivityListRequest req)
        {
            return InternalRequestAsync<QueryActivityListResponse>(req, "QueryActivityList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据游标拉取活动活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityLiveCodeListRequest"/></param>
        /// <returns><see cref="QueryActivityLiveCodeListResponse"/></returns>
        public Task<QueryActivityLiveCodeListResponse> QueryActivityLiveCodeList(QueryActivityLiveCodeListRequest req)
        {
            return InternalRequestAsync<QueryActivityLiveCodeListResponse>(req, "QueryActivityLiveCodeList");
        }

        /// <summary>
        /// 根据游标拉取活动活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityLiveCodeListRequest"/></param>
        /// <returns><see cref="QueryActivityLiveCodeListResponse"/></returns>
        public QueryActivityLiveCodeListResponse QueryActivityLiveCodeListSync(QueryActivityLiveCodeListRequest req)
        {
            return InternalRequestAsync<QueryActivityLiveCodeListResponse>(req, "QueryActivityLiveCodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间范围内发生过到店的潜客到店信息
        /// </summary>
        /// <param name="req"><see cref="QueryArrivalListRequest"/></param>
        /// <returns><see cref="QueryArrivalListResponse"/></returns>
        public Task<QueryArrivalListResponse> QueryArrivalList(QueryArrivalListRequest req)
        {
            return InternalRequestAsync<QueryArrivalListResponse>(req, "QueryArrivalList");
        }

        /// <summary>
        /// 查询指定时间范围内发生过到店的潜客到店信息
        /// </summary>
        /// <param name="req"><see cref="QueryArrivalListRequest"/></param>
        /// <returns><see cref="QueryArrivalListResponse"/></returns>
        public QueryArrivalListResponse QueryArrivalListSync(QueryArrivalListRequest req)
        {
            return InternalRequestAsync<QueryArrivalListResponse>(req, "QueryArrivalList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据游标拉取渠道活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChannelCodeListRequest"/></param>
        /// <returns><see cref="QueryChannelCodeListResponse"/></returns>
        public Task<QueryChannelCodeListResponse> QueryChannelCodeList(QueryChannelCodeListRequest req)
        {
            return InternalRequestAsync<QueryChannelCodeListResponse>(req, "QueryChannelCodeList");
        }

        /// <summary>
        /// 根据游标拉取渠道活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChannelCodeListRequest"/></param>
        /// <returns><see cref="QueryChannelCodeListResponse"/></returns>
        public QueryChannelCodeListResponse QueryChannelCodeListSync(QueryChannelCodeListRequest req)
        {
            return InternalRequestAsync<QueryChannelCodeListResponse>(req, "QueryChannelCodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据游标拉取会话存档列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChatArchivingListRequest"/></param>
        /// <returns><see cref="QueryChatArchivingListResponse"/></returns>
        public Task<QueryChatArchivingListResponse> QueryChatArchivingList(QueryChatArchivingListRequest req)
        {
            return InternalRequestAsync<QueryChatArchivingListResponse>(req, "QueryChatArchivingList");
        }

        /// <summary>
        /// 根据游标拉取会话存档列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChatArchivingListRequest"/></param>
        /// <returns><see cref="QueryChatArchivingListResponse"/></returns>
        public QueryChatArchivingListResponse QueryChatArchivingListSync(QueryChatArchivingListRequest req)
        {
            return InternalRequestAsync<QueryChatArchivingListResponse>(req, "QueryChatArchivingList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过此接口获取线索列表。
        /// </summary>
        /// <param name="req"><see cref="QueryClueInfoListRequest"/></param>
        /// <returns><see cref="QueryClueInfoListResponse"/></returns>
        public Task<QueryClueInfoListResponse> QueryClueInfoList(QueryClueInfoListRequest req)
        {
            return InternalRequestAsync<QueryClueInfoListResponse>(req, "QueryClueInfoList");
        }

        /// <summary>
        /// 企业可通过此接口获取线索列表。
        /// </summary>
        /// <param name="req"><see cref="QueryClueInfoListRequest"/></param>
        /// <returns><see cref="QueryClueInfoListResponse"/></returns>
        public QueryClueInfoListResponse QueryClueInfoListSync(QueryClueInfoListRequest req)
        {
            return InternalRequestAsync<QueryClueInfoListResponse>(req, "QueryClueInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口拉取租户/指定成员/部门在指定日期范围内的CRM跟进统计数据
        /// </summary>
        /// <param name="req"><see cref="QueryCrmStatisticsRequest"/></param>
        /// <returns><see cref="QueryCrmStatisticsResponse"/></returns>
        public Task<QueryCrmStatisticsResponse> QueryCrmStatistics(QueryCrmStatisticsRequest req)
        {
            return InternalRequestAsync<QueryCrmStatisticsResponse>(req, "QueryCrmStatistics");
        }

        /// <summary>
        /// 通过接口拉取租户/指定成员/部门在指定日期范围内的CRM跟进统计数据
        /// </summary>
        /// <param name="req"><see cref="QueryCrmStatisticsRequest"/></param>
        /// <returns><see cref="QueryCrmStatisticsResponse"/></returns>
        public QueryCrmStatisticsResponse QueryCrmStatisticsSync(QueryCrmStatisticsRequest req)
        {
            return InternalRequestAsync<QueryCrmStatisticsResponse>(req, "QueryCrmStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口拉取SaaS内C端外部联系人在指定时间范围内的行为事件明细。此接口提供的数据以天为维度，查询的时间范围为[start_time,end_time]，即前后均为闭区间，支持的最大查询跨度为365天。
        /// </summary>
        /// <param name="req"><see cref="QueryCustomerEventDetailStatisticsRequest"/></param>
        /// <returns><see cref="QueryCustomerEventDetailStatisticsResponse"/></returns>
        public Task<QueryCustomerEventDetailStatisticsResponse> QueryCustomerEventDetailStatistics(QueryCustomerEventDetailStatisticsRequest req)
        {
            return InternalRequestAsync<QueryCustomerEventDetailStatisticsResponse>(req, "QueryCustomerEventDetailStatistics");
        }

        /// <summary>
        /// 通过接口拉取SaaS内C端外部联系人在指定时间范围内的行为事件明细。此接口提供的数据以天为维度，查询的时间范围为[start_time,end_time]，即前后均为闭区间，支持的最大查询跨度为365天。
        /// </summary>
        /// <param name="req"><see cref="QueryCustomerEventDetailStatisticsRequest"/></param>
        /// <returns><see cref="QueryCustomerEventDetailStatisticsResponse"/></returns>
        public QueryCustomerEventDetailStatisticsResponse QueryCustomerEventDetailStatisticsSync(QueryCustomerEventDetailStatisticsRequest req)
        {
            return InternalRequestAsync<QueryCustomerEventDetailStatisticsResponse>(req, "QueryCustomerEventDetailStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口拉取租户已有潜客客户档案列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryCustomerProfileListRequest"/></param>
        /// <returns><see cref="QueryCustomerProfileListResponse"/></returns>
        public Task<QueryCustomerProfileListResponse> QueryCustomerProfileList(QueryCustomerProfileListRequest req)
        {
            return InternalRequestAsync<QueryCustomerProfileListResponse>(req, "QueryCustomerProfileList");
        }

        /// <summary>
        /// 通过接口拉取租户已有潜客客户档案列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryCustomerProfileListRequest"/></param>
        /// <returns><see cref="QueryCustomerProfileListResponse"/></returns>
        public QueryCustomerProfileListResponse QueryCustomerProfileListSync(QueryCustomerProfileListRequest req)
        {
            return InternalRequestAsync<QueryCustomerProfileListResponse>(req, "QueryCustomerProfileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过此接口获取录入在企微SaaS平台上的经销商信息。
        /// </summary>
        /// <param name="req"><see cref="QueryDealerInfoListRequest"/></param>
        /// <returns><see cref="QueryDealerInfoListResponse"/></returns>
        public Task<QueryDealerInfoListResponse> QueryDealerInfoList(QueryDealerInfoListRequest req)
        {
            return InternalRequestAsync<QueryDealerInfoListResponse>(req, "QueryDealerInfoList");
        }

        /// <summary>
        /// 企业可通过此接口获取录入在企微SaaS平台上的经销商信息。
        /// </summary>
        /// <param name="req"><see cref="QueryDealerInfoListRequest"/></param>
        /// <returns><see cref="QueryDealerInfoListResponse"/></returns>
        public QueryDealerInfoListResponse QueryDealerInfoListSync(QueryDealerInfoListRequest req)
        {
            return InternalRequestAsync<QueryDealerInfoListResponse>(req, "QueryDealerInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过此接口，根据外部联系人的userid，拉取外部联系人详情
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactDetailRequest"/></param>
        /// <returns><see cref="QueryExternalContactDetailResponse"/></returns>
        public Task<QueryExternalContactDetailResponse> QueryExternalContactDetail(QueryExternalContactDetailRequest req)
        {
            return InternalRequestAsync<QueryExternalContactDetailResponse>(req, "QueryExternalContactDetail");
        }

        /// <summary>
        /// 企业可通过此接口，根据外部联系人的userid，拉取外部联系人详情
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactDetailRequest"/></param>
        /// <returns><see cref="QueryExternalContactDetailResponse"/></returns>
        public QueryExternalContactDetailResponse QueryExternalContactDetailSync(QueryExternalContactDetailRequest req)
        {
            return InternalRequestAsync<QueryExternalContactDetailResponse>(req, "QueryExternalContactDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过传入起始和结束时间，获取该时间段的外部联系人详情列表
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactDetailByDateRequest"/></param>
        /// <returns><see cref="QueryExternalContactDetailByDateResponse"/></returns>
        public Task<QueryExternalContactDetailByDateResponse> QueryExternalContactDetailByDate(QueryExternalContactDetailByDateRequest req)
        {
            return InternalRequestAsync<QueryExternalContactDetailByDateResponse>(req, "QueryExternalContactDetailByDate");
        }

        /// <summary>
        /// 企业可通过传入起始和结束时间，获取该时间段的外部联系人详情列表
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactDetailByDateRequest"/></param>
        /// <returns><see cref="QueryExternalContactDetailByDateResponse"/></returns>
        public QueryExternalContactDetailByDateResponse QueryExternalContactDetailByDateSync(QueryExternalContactDetailByDateRequest req)
        {
            return InternalRequestAsync<QueryExternalContactDetailByDateResponse>(req, "QueryExternalContactDetailByDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过此接口基于外部联系人获取指定成员添加的客户列表。客户是指配置了客户联系功能的成员所添加的外部联系人。没有配置客户联系功能的成员，所添加的外部联系人将不会作为客户返回。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactListRequest"/></param>
        /// <returns><see cref="QueryExternalContactListResponse"/></returns>
        public Task<QueryExternalContactListResponse> QueryExternalContactList(QueryExternalContactListRequest req)
        {
            return InternalRequestAsync<QueryExternalContactListResponse>(req, "QueryExternalContactList");
        }

        /// <summary>
        /// 企业可通过此接口基于外部联系人获取指定成员添加的客户列表。客户是指配置了客户联系功能的成员所添加的外部联系人。没有配置客户联系功能的成员，所添加的外部联系人将不会作为客户返回。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactListRequest"/></param>
        /// <returns><see cref="QueryExternalContactListResponse"/></returns>
        public QueryExternalContactListResponse QueryExternalContactListSync(QueryExternalContactListRequest req)
        {
            return InternalRequestAsync<QueryExternalContactListResponse>(req, "QueryExternalContactList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口拉取租户在指定时间范围内的外部联系人添加/删除明细，此接口提供的数据以天为维度，查询的时间范围为[StarTime, EndTime]，即前后均为闭区间，支持的最大查询跨度为365天；
        /// </summary>
        /// <param name="req"><see cref="QueryExternalUserEventListRequest"/></param>
        /// <returns><see cref="QueryExternalUserEventListResponse"/></returns>
        public Task<QueryExternalUserEventListResponse> QueryExternalUserEventList(QueryExternalUserEventListRequest req)
        {
            return InternalRequestAsync<QueryExternalUserEventListResponse>(req, "QueryExternalUserEventList");
        }

        /// <summary>
        /// 通过接口拉取租户在指定时间范围内的外部联系人添加/删除明细，此接口提供的数据以天为维度，查询的时间范围为[StarTime, EndTime]，即前后均为闭区间，支持的最大查询跨度为365天；
        /// </summary>
        /// <param name="req"><see cref="QueryExternalUserEventListRequest"/></param>
        /// <returns><see cref="QueryExternalUserEventListResponse"/></returns>
        public QueryExternalUserEventListResponse QueryExternalUserEventListSync(QueryExternalUserEventListRequest req)
        {
            return InternalRequestAsync<QueryExternalUserEventListResponse>(req, "QueryExternalUserEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过此接口将企业主体对应的外部联系人id转换为乐销车应用主体对应的外部联系人。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalUserMappingInfoRequest"/></param>
        /// <returns><see cref="QueryExternalUserMappingInfoResponse"/></returns>
        public Task<QueryExternalUserMappingInfoResponse> QueryExternalUserMappingInfo(QueryExternalUserMappingInfoRequest req)
        {
            return InternalRequestAsync<QueryExternalUserMappingInfoResponse>(req, "QueryExternalUserMappingInfo");
        }

        /// <summary>
        /// 企业可通过此接口将企业主体对应的外部联系人id转换为乐销车应用主体对应的外部联系人。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalUserMappingInfoRequest"/></param>
        /// <returns><see cref="QueryExternalUserMappingInfoResponse"/></returns>
        public QueryExternalUserMappingInfoResponse QueryExternalUserMappingInfoSync(QueryExternalUserMappingInfoRequest req)
        {
            return InternalRequestAsync<QueryExternalUserMappingInfoResponse>(req, "QueryExternalUserMappingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间范围内发生过跟进的潜客信息
        /// </summary>
        /// <param name="req"><see cref="QueryFollowListRequest"/></param>
        /// <returns><see cref="QueryFollowListResponse"/></returns>
        public Task<QueryFollowListResponse> QueryFollowList(QueryFollowListRequest req)
        {
            return InternalRequestAsync<QueryFollowListResponse>(req, "QueryFollowList");
        }

        /// <summary>
        /// 查询指定时间范围内发生过跟进的潜客信息
        /// </summary>
        /// <param name="req"><see cref="QueryFollowListRequest"/></param>
        /// <returns><see cref="QueryFollowListResponse"/></returns>
        public QueryFollowListResponse QueryFollowListSync(QueryFollowListRequest req)
        {
            return InternalRequestAsync<QueryFollowListResponse>(req, "QueryFollowList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口获取license对应的详细信息
        /// </summary>
        /// <param name="req"><see cref="QueryLicenseInfoRequest"/></param>
        /// <returns><see cref="QueryLicenseInfoResponse"/></returns>
        public Task<QueryLicenseInfoResponse> QueryLicenseInfo(QueryLicenseInfoRequest req)
        {
            return InternalRequestAsync<QueryLicenseInfoResponse>(req, "QueryLicenseInfo");
        }

        /// <summary>
        /// 该接口获取license对应的详细信息
        /// </summary>
        /// <param name="req"><see cref="QueryLicenseInfoRequest"/></param>
        /// <returns><see cref="QueryLicenseInfoResponse"/></returns>
        public QueryLicenseInfoResponse QueryLicenseInfoSync(QueryLicenseInfoRequest req)
        {
            return InternalRequestAsync<QueryLicenseInfoResponse>(req, "QueryLicenseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口按类型拉取租户当前的素材列表及关键信息
        /// </summary>
        /// <param name="req"><see cref="QueryMaterialListRequest"/></param>
        /// <returns><see cref="QueryMaterialListResponse"/></returns>
        public Task<QueryMaterialListResponse> QueryMaterialList(QueryMaterialListRequest req)
        {
            return InternalRequestAsync<QueryMaterialListResponse>(req, "QueryMaterialList");
        }

        /// <summary>
        /// 通过接口按类型拉取租户当前的素材列表及关键信息
        /// </summary>
        /// <param name="req"><see cref="QueryMaterialListRequest"/></param>
        /// <returns><see cref="QueryMaterialListResponse"/></returns>
        public QueryMaterialListResponse QueryMaterialListSync(QueryMaterialListRequest req)
        {
            return InternalRequestAsync<QueryMaterialListResponse>(req, "QueryMaterialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询小程序码列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryMiniAppCodeListRequest"/></param>
        /// <returns><see cref="QueryMiniAppCodeListResponse"/></returns>
        public Task<QueryMiniAppCodeListResponse> QueryMiniAppCodeList(QueryMiniAppCodeListRequest req)
        {
            return InternalRequestAsync<QueryMiniAppCodeListResponse>(req, "QueryMiniAppCodeList");
        }

        /// <summary>
        /// 查询小程序码列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryMiniAppCodeListRequest"/></param>
        /// <returns><see cref="QueryMiniAppCodeListResponse"/></returns>
        public QueryMiniAppCodeListResponse QueryMiniAppCodeListSync(QueryMiniAppCodeListRequest req)
        {
            return InternalRequestAsync<QueryMiniAppCodeListResponse>(req, "QueryMiniAppCodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口拉取SaaS内企业成员在指定时间范围内的行为事件明细。此接口提供的数据以天为维度，查询的时间范围为[start_time,end_time]，即前后均为闭区间，支持的最大查询跨度为365天。
        /// </summary>
        /// <param name="req"><see cref="QueryStaffEventDetailStatisticsRequest"/></param>
        /// <returns><see cref="QueryStaffEventDetailStatisticsResponse"/></returns>
        public Task<QueryStaffEventDetailStatisticsResponse> QueryStaffEventDetailStatistics(QueryStaffEventDetailStatisticsRequest req)
        {
            return InternalRequestAsync<QueryStaffEventDetailStatisticsResponse>(req, "QueryStaffEventDetailStatistics");
        }

        /// <summary>
        /// 通过接口拉取SaaS内企业成员在指定时间范围内的行为事件明细。此接口提供的数据以天为维度，查询的时间范围为[start_time,end_time]，即前后均为闭区间，支持的最大查询跨度为365天。
        /// </summary>
        /// <param name="req"><see cref="QueryStaffEventDetailStatisticsRequest"/></param>
        /// <returns><see cref="QueryStaffEventDetailStatisticsResponse"/></returns>
        public QueryStaffEventDetailStatisticsResponse QueryStaffEventDetailStatisticsSync(QueryStaffEventDetailStatisticsRequest req)
        {
            return InternalRequestAsync<QueryStaffEventDetailStatisticsResponse>(req, "QueryStaffEventDetailStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询企业成员信息列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryUserInfoListRequest"/></param>
        /// <returns><see cref="QueryUserInfoListResponse"/></returns>
        public Task<QueryUserInfoListResponse> QueryUserInfoList(QueryUserInfoListRequest req)
        {
            return InternalRequestAsync<QueryUserInfoListResponse>(req, "QueryUserInfoList");
        }

        /// <summary>
        /// 查询企业成员信息列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryUserInfoListRequest"/></param>
        /// <returns><see cref="QueryUserInfoListResponse"/></returns>
        public QueryUserInfoListResponse QueryUserInfoListSync(QueryUserInfoListRequest req)
        {
            return InternalRequestAsync<QueryUserInfoListResponse>(req, "QueryUserInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业可通过此接口获取企微SaaS平台上的车系车型信息。
        /// </summary>
        /// <param name="req"><see cref="QueryVehicleInfoListRequest"/></param>
        /// <returns><see cref="QueryVehicleInfoListResponse"/></returns>
        public Task<QueryVehicleInfoListResponse> QueryVehicleInfoList(QueryVehicleInfoListRequest req)
        {
            return InternalRequestAsync<QueryVehicleInfoListResponse>(req, "QueryVehicleInfoList");
        }

        /// <summary>
        /// 企业可通过此接口获取企微SaaS平台上的车系车型信息。
        /// </summary>
        /// <param name="req"><see cref="QueryVehicleInfoListRequest"/></param>
        /// <returns><see cref="QueryVehicleInfoListResponse"/></returns>
        public QueryVehicleInfoListResponse QueryVehicleInfoListSync(QueryVehicleInfoListRequest req)
        {
            return InternalRequestAsync<QueryVehicleInfoListResponse>(req, "QueryVehicleInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

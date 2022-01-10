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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WavClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 新增渠道活码接口
        /// </summary>
        /// <param name="req"><see cref="CreateChannelCodeRequest"/></param>
        /// <returns><see cref="CreateChannelCodeResponse"/></returns>
        public async Task<CreateChannelCodeResponse> CreateChannelCode(CreateChannelCodeRequest req)
        {
             JsonResponseModel<CreateChannelCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateChannelCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChannelCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增渠道活码接口
        /// </summary>
        /// <param name="req"><see cref="CreateChannelCodeRequest"/></param>
        /// <returns><see cref="CreateChannelCodeResponse"/></returns>
        public CreateChannelCodeResponse CreateChannelCodeSync(CreateChannelCodeRequest req)
        {
             JsonResponseModel<CreateChannelCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateChannelCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChannelCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户设置标签库, 每个企业最多可配置3000个企业标签。
        /// </summary>
        /// <param name="req"><see cref="CreateCorpTagRequest"/></param>
        /// <returns><see cref="CreateCorpTagResponse"/></returns>
        public async Task<CreateCorpTagResponse> CreateCorpTag(CreateCorpTagRequest req)
        {
             JsonResponseModel<CreateCorpTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCorpTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCorpTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户设置标签库, 每个企业最多可配置3000个企业标签。
        /// </summary>
        /// <param name="req"><see cref="CreateCorpTagRequest"/></param>
        /// <returns><see cref="CreateCorpTagResponse"/></returns>
        public CreateCorpTagResponse CreateCorpTagSync(CreateCorpTagRequest req)
        {
             JsonResponseModel<CreateCorpTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCorpTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCorpTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 线索回收接口
        /// </summary>
        /// <param name="req"><see cref="CreateLeadRequest"/></param>
        /// <returns><see cref="CreateLeadResponse"/></returns>
        public async Task<CreateLeadResponse> CreateLead(CreateLeadRequest req)
        {
             JsonResponseModel<CreateLeadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLead");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLeadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 线索回收接口
        /// </summary>
        /// <param name="req"><see cref="CreateLeadRequest"/></param>
        /// <returns><see cref="CreateLeadResponse"/></returns>
        public CreateLeadResponse CreateLeadSync(CreateLeadRequest req)
        {
             JsonResponseModel<CreateLeadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLead");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLeadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取活动参与列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityJoinListRequest"/></param>
        /// <returns><see cref="QueryActivityJoinListResponse"/></returns>
        public async Task<QueryActivityJoinListResponse> QueryActivityJoinList(QueryActivityJoinListRequest req)
        {
             JsonResponseModel<QueryActivityJoinListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryActivityJoinList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryActivityJoinListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取活动参与列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityJoinListRequest"/></param>
        /// <returns><see cref="QueryActivityJoinListResponse"/></returns>
        public QueryActivityJoinListResponse QueryActivityJoinListSync(QueryActivityJoinListRequest req)
        {
             JsonResponseModel<QueryActivityJoinListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryActivityJoinList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryActivityJoinListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取活动列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityListRequest"/></param>
        /// <returns><see cref="QueryActivityListResponse"/></returns>
        public async Task<QueryActivityListResponse> QueryActivityList(QueryActivityListRequest req)
        {
             JsonResponseModel<QueryActivityListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryActivityList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryActivityListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取活动列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityListRequest"/></param>
        /// <returns><see cref="QueryActivityListResponse"/></returns>
        public QueryActivityListResponse QueryActivityListSync(QueryActivityListRequest req)
        {
             JsonResponseModel<QueryActivityListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryActivityList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryActivityListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取活动活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityLiveCodeListRequest"/></param>
        /// <returns><see cref="QueryActivityLiveCodeListResponse"/></returns>
        public async Task<QueryActivityLiveCodeListResponse> QueryActivityLiveCodeList(QueryActivityLiveCodeListRequest req)
        {
             JsonResponseModel<QueryActivityLiveCodeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryActivityLiveCodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryActivityLiveCodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取活动活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryActivityLiveCodeListRequest"/></param>
        /// <returns><see cref="QueryActivityLiveCodeListResponse"/></returns>
        public QueryActivityLiveCodeListResponse QueryActivityLiveCodeListSync(QueryActivityLiveCodeListRequest req)
        {
             JsonResponseModel<QueryActivityLiveCodeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryActivityLiveCodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryActivityLiveCodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取渠道活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChannelCodeListRequest"/></param>
        /// <returns><see cref="QueryChannelCodeListResponse"/></returns>
        public async Task<QueryChannelCodeListResponse> QueryChannelCodeList(QueryChannelCodeListRequest req)
        {
             JsonResponseModel<QueryChannelCodeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChannelCodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChannelCodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取渠道活码列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChannelCodeListRequest"/></param>
        /// <returns><see cref="QueryChannelCodeListResponse"/></returns>
        public QueryChannelCodeListResponse QueryChannelCodeListSync(QueryChannelCodeListRequest req)
        {
             JsonResponseModel<QueryChannelCodeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChannelCodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChannelCodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取会话存档列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChatArchivingListRequest"/></param>
        /// <returns><see cref="QueryChatArchivingListResponse"/></returns>
        public async Task<QueryChatArchivingListResponse> QueryChatArchivingList(QueryChatArchivingListRequest req)
        {
             JsonResponseModel<QueryChatArchivingListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryChatArchivingList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChatArchivingListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据游标拉取会话存档列表信息
        /// </summary>
        /// <param name="req"><see cref="QueryChatArchivingListRequest"/></param>
        /// <returns><see cref="QueryChatArchivingListResponse"/></returns>
        public QueryChatArchivingListResponse QueryChatArchivingListSync(QueryChatArchivingListRequest req)
        {
             JsonResponseModel<QueryChatArchivingListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryChatArchivingList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryChatArchivingListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口获取线索列表。
        /// </summary>
        /// <param name="req"><see cref="QueryClueInfoListRequest"/></param>
        /// <returns><see cref="QueryClueInfoListResponse"/></returns>
        public async Task<QueryClueInfoListResponse> QueryClueInfoList(QueryClueInfoListRequest req)
        {
             JsonResponseModel<QueryClueInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryClueInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryClueInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口获取线索列表。
        /// </summary>
        /// <param name="req"><see cref="QueryClueInfoListRequest"/></param>
        /// <returns><see cref="QueryClueInfoListResponse"/></returns>
        public QueryClueInfoListResponse QueryClueInfoListSync(QueryClueInfoListRequest req)
        {
             JsonResponseModel<QueryClueInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryClueInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryClueInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口获取录入在企微SaaS平台上的经销商信息。
        /// </summary>
        /// <param name="req"><see cref="QueryDealerInfoListRequest"/></param>
        /// <returns><see cref="QueryDealerInfoListResponse"/></returns>
        public async Task<QueryDealerInfoListResponse> QueryDealerInfoList(QueryDealerInfoListRequest req)
        {
             JsonResponseModel<QueryDealerInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDealerInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDealerInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口获取录入在企微SaaS平台上的经销商信息。
        /// </summary>
        /// <param name="req"><see cref="QueryDealerInfoListRequest"/></param>
        /// <returns><see cref="QueryDealerInfoListResponse"/></returns>
        public QueryDealerInfoListResponse QueryDealerInfoListSync(QueryDealerInfoListRequest req)
        {
             JsonResponseModel<QueryDealerInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDealerInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDealerInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口，根据外部联系人的userid，拉取外部联系人详情
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactDetailRequest"/></param>
        /// <returns><see cref="QueryExternalContactDetailResponse"/></returns>
        public async Task<QueryExternalContactDetailResponse> QueryExternalContactDetail(QueryExternalContactDetailRequest req)
        {
             JsonResponseModel<QueryExternalContactDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryExternalContactDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExternalContactDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口，根据外部联系人的userid，拉取外部联系人详情
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactDetailRequest"/></param>
        /// <returns><see cref="QueryExternalContactDetailResponse"/></returns>
        public QueryExternalContactDetailResponse QueryExternalContactDetailSync(QueryExternalContactDetailRequest req)
        {
             JsonResponseModel<QueryExternalContactDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryExternalContactDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExternalContactDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口基于外部联系人获取指定成员添加的客户列表。客户是指配置了客户联系功能的成员所添加的外部联系人。没有配置客户联系功能的成员，所添加的外部联系人将不会作为客户返回。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactListRequest"/></param>
        /// <returns><see cref="QueryExternalContactListResponse"/></returns>
        public async Task<QueryExternalContactListResponse> QueryExternalContactList(QueryExternalContactListRequest req)
        {
             JsonResponseModel<QueryExternalContactListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryExternalContactList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExternalContactListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口基于外部联系人获取指定成员添加的客户列表。客户是指配置了客户联系功能的成员所添加的外部联系人。没有配置客户联系功能的成员，所添加的外部联系人将不会作为客户返回。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalContactListRequest"/></param>
        /// <returns><see cref="QueryExternalContactListResponse"/></returns>
        public QueryExternalContactListResponse QueryExternalContactListSync(QueryExternalContactListRequest req)
        {
             JsonResponseModel<QueryExternalContactListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryExternalContactList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExternalContactListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口将企业主体对应的外部联系人id转换为乐销车应用主体对应的外部联系人。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalUserMappingInfoRequest"/></param>
        /// <returns><see cref="QueryExternalUserMappingInfoResponse"/></returns>
        public async Task<QueryExternalUserMappingInfoResponse> QueryExternalUserMappingInfo(QueryExternalUserMappingInfoRequest req)
        {
             JsonResponseModel<QueryExternalUserMappingInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryExternalUserMappingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExternalUserMappingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口将企业主体对应的外部联系人id转换为乐销车应用主体对应的外部联系人。
        /// </summary>
        /// <param name="req"><see cref="QueryExternalUserMappingInfoRequest"/></param>
        /// <returns><see cref="QueryExternalUserMappingInfoResponse"/></returns>
        public QueryExternalUserMappingInfoResponse QueryExternalUserMappingInfoSync(QueryExternalUserMappingInfoRequest req)
        {
             JsonResponseModel<QueryExternalUserMappingInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryExternalUserMappingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExternalUserMappingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口获取license对应的详细信息
        /// </summary>
        /// <param name="req"><see cref="QueryLicenseInfoRequest"/></param>
        /// <returns><see cref="QueryLicenseInfoResponse"/></returns>
        public async Task<QueryLicenseInfoResponse> QueryLicenseInfo(QueryLicenseInfoRequest req)
        {
             JsonResponseModel<QueryLicenseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryLicenseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryLicenseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口获取license对应的详细信息
        /// </summary>
        /// <param name="req"><see cref="QueryLicenseInfoRequest"/></param>
        /// <returns><see cref="QueryLicenseInfoResponse"/></returns>
        public QueryLicenseInfoResponse QueryLicenseInfoSync(QueryLicenseInfoRequest req)
        {
             JsonResponseModel<QueryLicenseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryLicenseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryLicenseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询小程序码列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryMiniAppCodeListRequest"/></param>
        /// <returns><see cref="QueryMiniAppCodeListResponse"/></returns>
        public async Task<QueryMiniAppCodeListResponse> QueryMiniAppCodeList(QueryMiniAppCodeListRequest req)
        {
             JsonResponseModel<QueryMiniAppCodeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMiniAppCodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMiniAppCodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询小程序码列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryMiniAppCodeListRequest"/></param>
        /// <returns><see cref="QueryMiniAppCodeListResponse"/></returns>
        public QueryMiniAppCodeListResponse QueryMiniAppCodeListSync(QueryMiniAppCodeListRequest req)
        {
             JsonResponseModel<QueryMiniAppCodeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMiniAppCodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMiniAppCodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口获取企微SaaS平台上的车系车型信息。
        /// </summary>
        /// <param name="req"><see cref="QueryVehicleInfoListRequest"/></param>
        /// <returns><see cref="QueryVehicleInfoListResponse"/></returns>
        public async Task<QueryVehicleInfoListResponse> QueryVehicleInfoList(QueryVehicleInfoListRequest req)
        {
             JsonResponseModel<QueryVehicleInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVehicleInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVehicleInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业可通过此接口获取企微SaaS平台上的车系车型信息。
        /// </summary>
        /// <param name="req"><see cref="QueryVehicleInfoListRequest"/></param>
        /// <returns><see cref="QueryVehicleInfoListResponse"/></returns>
        public QueryVehicleInfoListResponse QueryVehicleInfoListSync(QueryVehicleInfoListRequest req)
        {
             JsonResponseModel<QueryVehicleInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVehicleInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVehicleInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
